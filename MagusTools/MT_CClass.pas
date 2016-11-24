unit MT_CClass; // Magus-Tools Character-Class ver. 2.0

interface

uses Windows, Controls, Math, Classes, SysUtils, Contnrs, Messages, StrUtils,
     CustomLists, DebugUnit;

const
// Message constants (currently completely unused)
  UM_STATCHANGE = WM_APP + $0001; // Notifies the stat objects that one of them has been changed

// General constants for easy access
  MaxKAP = 375;

// REFERENCE VALUES FOR USER STATS
  USER_STAT_LOW  = 0;
  USER_STAT_HIGH = 38;

// How many types of data does a single line in WeaponDataFile hold
  WEAPONDATALENGTH = 13;
  ARMORDATALENGTH  = 6;

// You get bonus damage if your ERO is above this number
  EROBONUSTHRESHOLD  = 16;
// You get bonuses to your combat stats above this number
  STATBONUSTHRESHOLD = 10;

// Use this with TStat.GetKAP function, for special cases;
  UseDefaults   = -1;
  IgnoreOptions = True;

// Use this if no visual update is required when checking a TStat's CurrentValue
  NoVisualUpdate = False;

// These array size-constants are 1 less then the value they represent
// Ex.: 2 = 0..2 => 3 elements
// This is for the TComboBoxes' ItemIndex property
  MaxGender       = 2;
  MaxChr          = 11;
  MaxRace         = 6;
  MaxClass        = 13;
  MaxBirthplace   = 50;
  MaxReligion     = 37;
  MaxAge          = 30;

  MaxLanguage     = 16;
  MaxDeadLanguage = 12;
  MaxOccupation   = 59;
  MaxAnimals      = 89;

  MaxDiceName     = 5;

// Character Background Constants
  CBC_GenderStrings: array[0..MaxGender] of String =
    ('Férfi','Nõ','Egyéb');

  CBC_ChrStrings: array[0..MaxChr] of String =
    ('Élet','Élet - Rend','Élet - Káosz',
     'Rend','Rend - Élet','Rend - Halál',
     'Káosz','Káosz - Élet','Káosz - Halál',
     'Halál','Halál - Rend','Halál - Káosz');

  CBC_RaceStrings: array[0..MaxRace] of String =
    ('Ember','Elf','Félelf','Törpe','Udvari Ork','Goblin','Gnóm');

  CBC_ClassStrings: array[0..MaxClass] of String =
    ('Harcos','Gladiátor','Fejvadász','Lovag','Tolvaj',
     'Bárd','Pap','Paplovag','Harcmûvész','Kardmûvész',
     'Boszorkány','Boszorkánymester','Tûzvarázsló','Varázsló');

  CBC_BirthplaceStrings: array[0..MaxBirthplace] of String =
    ('Abaszisz','Abu Baldek','Abu Baldek Shibara','Al Abadana','Al Avdal',
     'Al Hidema','Al Madoba','Al Muggafe','Alidar','Alidax','Anuria','Doran',
     'Dwyll Unió','Edorl','El Hamed','El Qusarma','El Sobira','Enismon',
     'Enoszuke','Eren','Erigow','Erion','Északi városállamok','Gianag',
     'Gorvik','Gro-Ugon','Haonwell','Hat város szövetsége','Ilanor','Jankar',
     'Kahre','Kereskedõ hercegségek','Krán','Lar-Dor','Niare','Ordan','Predoc',
     'Pyarron','Riegoy Városállamok','Rowon','Sempyer','Shadon',
     'Sirenar szövetség','Syburr','Tarin','Tiadlan','Toron','Új-Pyarron',
     'Városállamok','Viadomo','Yllinor');

  CBC_ReligionStrings: array[0..MaxReligion] of String =
    ('Adron','Alborne','Antoh','Arel - Solyomcsõr',
     'Arel - Sólyomkarom','Arel - Solyomszív','Darton','Della',
     'Doldzsah','Domvik','Dreina','Dzsah',
     'Ellana','Felice','Galradzsa','Gilron',
     'Hitetlen','Kadal','Kaoraku','Krad',
     'Kyel','Leutaril','Morgena','Narmiraen',
     'Noir - Bálványtagadó','Noir - Befogadott','Orwella','Ramrik',
     'Ranagol','Ranil','Sogron - Lángvihar','Sogron - Tûztápláló',
     'Tharr','Tomatis','Tooma','Tyssa L’imenel',
     'Uwel','Verrion H’Anthall');

  CBC_ReligionMAStrings: array[0..MaxReligion] of String =
    ('Élet, Lélek','Élet, Lélek','Élet, Természet','Élet, Természet',
     'Természet, Halál','Természet, Lélek','Halál, Lélek','Lélek',
     'Természet, Lélek','Élet, Természet, Lélek','Élet, Halál','Élet, Lélek',
     'Élet, Lélek','Természet','Élet, Természet','Élet, Természet',
     '','Élet, Természet','Természet, Lélek','Élet, Lélek',
     'Élet, Halál, Lélek','Élet, Természet, Halál','Lélek, Halál','Természet',
     'Lélek, Halál','Élet, Lélek','Lélek, Halál','Élet, Természet, Halál',
     'Természet, Lélek, Halál','Természet, Lélek','Természet, Lélek','Élet, Természet, Lélek',
     'Lélek, Halál','Élet, Természet, Halál','Élet, Természet','Természet',
     'Élet, Lélek, Halál','Természet');

  CBC_LanguageStrings: array[0..MaxLanguage] of String =
    ('Aszisz','Barbár','Dwoon','Dzsad','Elf','Erv','Gnóm','Gorviki','Ilanori',
     'Kráni','Niarei','Nomád','Ork','Pyarroni','Shadoni','Toroni kyr','Törpe');

  CBC_DeadLanguageStrings: array[0..MaxDeadLanguage] of String =
    ('Amund','Angmar','Anur','Aquir','Crantai','Démonikus',
     'Dzsenn','Godoni','Híl','Kheton','Lupár','ÓElf','ÓKyr');

  CBC_OccupationStrings: array[0..MaxOccupation] of String =
    ('Asztalos','Ács','Bádogos','Bodnár','Borbély','Cipész','Csikós',
     'Csipkeverõ','Csizmadia','Cukrász','Esztergályos','Faszénégetõ',
     'Fazekas','Fogadós','Fuvaros','Fûszeres','Gyertyamártó',
     'Gyékényszövõ','Hangszerkészítõ','Juhász','Kalapos','Kádár',
     'Kályhás','Kárpitos','Kefekötõ','Kelmefestõ','Kerékgyártó',
     'Kondás','Kosárfonó','Kovács','Könyvkötõ','Kötélverõ','Köszörûs',
     'Kõfaragó','Kõmûves','Lakatos','Lovász','Lócsiszár','Mészáros',
     'Mészégetõ','Molnár','Nemezkészítõ','Órás','Ötvös','Papírmerítõ',
     'Pákász','Pék','Révész','Rézmûves','Sörfõzõ','Szabó','Szakács',
     'Szappanos','Szûcs','Takács','Tímár','Üveges','Varga',
     'Vályogvetõ','Vincellér');

  CBC_AnimalStrings: array[0..MaxAnimals] of String =
    ('Angolna','Antilop','Bagoly','Bálna','Béka','Bika','Bivaly','Birka',
     'Boa','Borz','Bölény','Cápa','Csiga','Csótány','Darázs','Denevér',
     'Disznó','Daru','Delfin','Egér','Elefánt','Ezüstróka','Fácán','Fóka',
     'Farkas','Görény','Gepárd','Gólya','Grizzly','Gyík','Galamb','Hangya',
     'Harcsa','Hattyú','Hering','Hiéna','Holló','Hód','Hörcsög','Jaguár',
     'Juh','Kacsa','Kakas','Kagyló','Kanári','Kardhal','Kecske','Keszeg',
     'Kígyó','Krokodil','Kutya','Lazac','Lepke','Liba','Ló','Lúd','Leopárd',
     'Macska','Majom','Marha','Menyét','Medve','Mókus','Mosómedve','Nyúl',
     'Oroszlán','Óriáskígyó','Ölyv','Páva','Patkány','Pisztráng','Piton',
     'Polip','Rák','Róka','Sakál','Sas','Sáska','Sün','Sirály','Szarvas',
     'Tehén','Tigris','Teknõs','Teve','Ürge','Vidra','Vipera','Viziló',
     'Zebra');

  CBC_DiceNames: array[0..MaxDiceName] of String =
    ('K2','K3','K6','K10','K20','K100');

// NAMES AND DEFAULT VALUES
// Component value section
type
  TRangeType = (stMIN, stMAX, stDEFAULT);

const
  ComponentIdentifiers: array[USER_STAT_LOW..USER_STAT_HIGH] of String =
    ('ERO','GYO','UGY','ALL','EGE','SZE','INT','AKE','ASZ','ERZ',
     'KE','TE','VE','CE','HMTSZ',
     'EP','FP','FPTSZ','KP','KPTSZ','LEVEL',
     'MP','MPTSZ','DAMAGE','PSZI','PSZITSZ',
     'AME','MME',
     'GENDER','CHR','RACE','CLASS','BIRTH','RELIGION','AGE',
     'KE_HM','TE_HM','VE_HM','CE_HM');

// Full-length names of TStats that can be modified by the user and trigger a refresh
  ComponentNames: array[USER_STAT_LOW..USER_STAT_HIGH] of String =
    ('Erõ','Gyorsaság','Ügyesség','Állóképesség','Egészség',                    // 00 .. 04
     'Szépség','Intelligencia','Akaraterõ','Asztrál','Érzékelés',               // 05 .. 09
     'KÉ','TÉ','VÉ','CÉ','HM / Szint',                                          // 10 .. 14
     'ÉP','FP','FP / Szint','KP','KP / Szint','Szint',                          // 15 .. 20
     'Mana','Mana / Szint','Sebzésjárulék','Pszi','Pszi / Szint',               // 21 .. 25
     'Asztrális Mágiaellenállás','Mentális Mágiaellenállás',                    // 26 .. 27
     'Nem','Jellem','Faj','Kaszt','Szülõföld','Vallás','Életkor',               // 28 .. 34
     'KÉ-re osztott HM','TÉ-re osztott HM',                                     // 35 .. 36
     'VÉ-re osztott HM','CÉ-re osztott HM');                                    // 37 .. 38

// Minimum, maximum and default values for user-modifiable stats
  ComponentRange: array[USER_STAT_LOW..USER_STAT_HIGH, stMin..stDefault] of Integer =
    ((3,20,12),(3,20,12),(3,20,12),(3,20,12),(3,20,12),
     (3,20,12),(3,20,12),(3,20,12),(3,20,12),(3,20,12),
     (0,100,0),(0,100,0),(0,100,0),(0,100,0), (0,20,0),
     (1,20,1),(1,50,1),(0,20,0),(0,100,0),(0,20,0),(1,20,1),
// Default settings for a new character, chosen from the CBC constants above
     (0,200,0),(0,10,0),(0,50,0),(0,131,0),(0,7,0),(0,200,0),(0,200,0),
     (0,MaxGender,0),(0,MaxChr,0),(0,MaxRace,0),(0,MaxClass,0),
     (0,MaxBirthplace,47),(0,MaxReligion,16),(16,MaxAge,18),
     (0,200,0),(0,200,0),(0,200,0),(0,200,0));

// Identifiers for TCustomCharacter.AddEquipment procedure
  Tag_Weapon = 1;
  Tag_Armor = 2;
  Tag_Equipment_General = 3;
  Tag_Equipment_Poison = 4;
  Tag_Equipment_Potion = 5;
  Tag_Equipment_MagicItem = 6;

////////////////////////////////////////////////////////////////////////////////
//////////////////////////    FORWARD DECLARATIONS    //////////////////////////
////////////////////////////////////////////////////////////////////////////////
type
  TEquipmentLocation = (elBackpack, elLeftHand, elRightHand, elHead, elTorso, elArms, elLegs, elFeet);
  TEquipmentMaterial = (emLeather, emGlass, emPaper, emWood, emBronze, emIron, emSteel, emMithril);
  TEquipmentCategory = (ecGeneral, ecWeapon, ecArmor, ecPoison, ecMagicItem, ecPotion, ecConsumable, ecContainer);
// ecGeneral: Általános felszerelés (pl. kulacs), ecWeapon: Fegyver, ecArmor: Páncél
// ecPoison: Mérgek, ecMagicItem: Varázstárgyak, ecPotion: Varázsitalok
// ecConsumable: Fogyóeszközök, ecContainer: Tárolók
  TWeaponCategory = (wcCleave, wcPiere, wcBlunt, wcPolearm, wcThrown, wcRanged, wcFirearm, wcShield, wcOther);
// ecCleave: Vágófegyverek, ecPiere: Szúrófegyverek, ecBlunt: Zúzófegyverek
// ecPolearm: Szálfegyverek, ecThrown: Dobófegyverek, ecRanged: Célzófegyverek
// ecFirearm: Tûzfegyverek, ecShield: Pajzsok, ecOther: Egyéb fegyverek
  TArmorCategory = (acHelmet, acVest, acGreaves, acGauntlets, acBoots);
//  TPoisonCategory = ();
  TSkillUpdateModifierAction = (umaUpdate, umaDelete);
  TNodeType = (itPrimaryNode, itSecondaryNode);

////////////////////////////////////////////////////////////////////////////////
/////////////////////////    RAW DATA STORAGE TYPES    /////////////////////////
////////////////////////////////////////////////////////////////////////////////
type
  TReqData = record
    ReqName: String;
    ReqValue: Integer;
    IsStat: Boolean;
  end;

  TLevelData = record
    Price: Integer;
    ValidFromLevel: Integer;
    Requirements: array of TReqData;
  end;

  TSkillData = record
    Name: String;
    Levels: array of TLevelData;
    IsPercentSkill: Boolean;
    SubTypeRefSkill: String;
  end;

  TWeaponData = record
    Name: String;
    Category: TWeaponCategory;
    Dmg_Min: Integer;
    Dmg_Max: Integer;
    Dmg_Add: Integer;
    TPK : Integer; // Tám / kör
    ReqType: String;
    ReqValue: Integer;
    DoubleHanded: Boolean;
    Stat_KE: Integer;
    Stat_TE: Integer;
    Stat_VE: Integer;
    Stat_CE: Integer;
    Stat_TAV: Integer;
    Stat_MGT: Integer;
  end;

  TArmorData = record
    Name: String;
    Stat_SFE: Integer;
    Stat_MGT: Integer;
    Category: TArmorCategory;
  end;

  TEquipmentData = record
    Name: String;
    Specials: String;
    CopperPrice: Integer;
    Category: TEquipmentCategory;
  end;

////////////////////////////////////////////////////////////////////////////////
/////////////////////////////    OBJECTS' CODE    //////////////////////////////
////////////////////////////////////////////////////////////////////////////////
type
  TCustomCharacter = class;
  TSkill = class;

  TStat = class(TObject)
  private
    FName: String;
    FShortName: String;
    FBaseValue: Integer;
    FCurrentValue: Integer;
    FBaseListPos: Integer; // Name's position in the CBC's constants' list
    FListPos: Integer; // Stat's position in the Statlist
    FOwner: TCustomCharacter;
    FModifiers: TIntegerList; // A modification value and a pointer to a TStat
    FModified: Boolean;
//    function GetCurrentValue: Integer;
    procedure SetBaseValue(const NewBaseValue: Integer);
    procedure SetModified(const NewValue: Boolean);
    procedure UpdateModifiers(ARequestingStat: TStat);
    procedure UpdateSkillModifiers(ARequestingSkillName: String;
      const ModifierUpdateAction: TSkillUpdateModifierAction = umaUpdate);
  public
    constructor Create(AOwner: TCustomCharacter = nil);
    destructor Destroy; override;
    function CurrentValue(const VisualUpdate: Boolean = True): Integer;
    function GetKAP(const AValue: Integer = -1; const AIgnoreOptions: Boolean = False): Integer;
    function GetModifierSum(const LeaveOutHM: Boolean = False): Integer;
    property Name: String read FName;
    property ShortName: String read FShortName;
    property BaseValue: Integer read FBaseValue write SetBaseValue;
//    property CurrentValue: Integer read GetCurrentValue;
    property Owner: TCustomCharacter read FOwner;
    property Modified: Boolean read FModified write SetModified;
    property Modifiers: TIntegerList read FModifiers;
    property BaseListPos: Integer read FBaseListPos;
    property ListPos: Integer read FListPos;
  end;

  TSkill = class(TObject)
  private
    FName: String;
    FValue: Integer;
    FPrice: Integer;
    FRequirements: TObjectList; // TRequirement
    FModified: Boolean;
    FPercentSkill: Boolean;
    FKapUsed: Boolean;
    FSubType: String;
    FSubTypeRefSkill: String;
  public
    constructor Create(AOwner: TCustomCharacter = nil);
    destructor Destroy; override;
    property Name: String read FName;
    property Value: Integer read FValue;
    property Price: Integer read FPrice;
    property Requirements: TObjectList read FRequirements;
    property IsPercentSkill: Boolean read FPercentSkill;
    property IsKapUsed: Boolean read FKapUsed;
    property SubType: String read FSubType;
    property SubTypeReference: String read FSubTypeRefSkill;
  end;

  TSkillCategoryNode = class(TObject)
  private
    FName: String;
    FNodeType: TNodeType;
  public
    property Name: String read FName;
    property NodeType: TNodeType read FNodeType;
  end;

// This is only used to store data from a file that will be assigned to not yet existing objects.
// Ex.: SubTypeRefSkill field must be read and stored, but cannot be assigned until all skill-objects are created first.
// Ex.: Requirements can reference to skills, that have not yet been created. They are stored in this separate object until then.
  TTemporaryStringHolder = class(TStringList);

  TRequirement = class(TObject)
  private
    FLevel: Integer;
    FValue: Integer;
    FOwner: TSkill;
    FStatReq: String;  // Name of a TStat object
    FSkillReq: String; // Name of a TSkill object
  public
    property Level: Integer read FLevel;
    property Value: Integer read FValue;
    property StatReq: String read FStatReq;
    property SkillReq: String read FSkillReq;
    property Owner: TSkill read FOwner;
  end;

  TKPCost = class(TObject)
  private
    FKPCost: Integer;
    FLevel: Integer;
  public
    property KPCost: Integer read FKPCost;
    property Level: Integer read FLevel;
  end;

  TEquipment = class(TObject)
  private
    FName: String;
    FCategory: TEquipmentCategory;
    FListPos: Integer;
    FAmount: Integer;
    FOwner: TCustomCharacter;
    FLocation: TEquipmentLocation;
    FMaterial: TEquipmentMaterial;
    FEnchanted: Boolean;
    FEnchantmentLevel: Byte; // 0: No; 1-5: Rúnamágia; 6-10: Mestermágia
  public
    property Name: String read FName;
    property Category: TEquipmentCategory read FCategory;
    property ListPos: Integer read FListPos;
    property Amount: Integer read FAmount;
    property Location: TEquipmentLocation read FLocation;
    property Material: TEquipmentMaterial read FMaterial;
    property Enchanted: Boolean read FEnchanted;
    property EnchantmentLevel: Byte read FEnchantmentLevel;
    property Owner: TCustomCharacter read FOwner;
  end;

  TCustomWeapon = class(TEquipment)
  private
    function GetDmg_Add: Integer;
    function GetDmg_Max: Integer;
    function GetDmg_Min: Integer;
    function GetDoubleHanded: Boolean;
    function GetReqType: String;
    function GetReqValue: Integer;
    function GetTPK : Integer; // Tám / kör
    function GetWeaponCategory: TWeaponCategory;
  public
    function GetDamageString(UseDiceRepresentation: Boolean = False): String;
    property WeaponCategory: TWeaponCategory read GetWeaponCategory;
    property Dmg_Min: Integer read GetDmg_Min;
    property Dmg_Max: Integer read GetDmg_Max;
    property Dmg_Add: Integer read GetDmg_Add;
    property TKP: Integer read GetTPK;
    property ReqType: String read GetReqType;
    property ReqValue: Integer read GetReqValue;
    property DoubleHanded: Boolean read GetDoubleHanded;
  end;

  TMeleeWeapon = class(TCustomWeapon)
  private
    FStat_KE: Integer;
    FStat_TE: Integer;
    FStat_VE: Integer;
  public
    property KE: Integer read FStat_KE;
    property TE: Integer read FStat_TE;
    property VE: Integer read FStat_VE;
  end;

  TRangedWeapon = class(TCustomWeapon)
  private
    FStat_KE: Integer;
    FStat_CE: Integer;
    FStat_TAV: Integer;
  public
    property KE: Integer read FStat_KE;
    property CE: Integer read FStat_CE;
    property Tav: Integer read FStat_Tav;
  end;

  TShield = class(TCustomWeapon)
  private
    FStat_KE: Integer;
    FStat_VE: Integer;
    FStat_MGT: Integer;
  public
    property KE: Integer read FStat_KE;
    property VE: Integer read FStat_VE;
    property MGT: Integer read FStat_MGT;
  end;

  TArmor = class(TEquipment)
  private
    FStat_SFE: Integer;
    FStat_MGT: Integer;
    function GetArmorCategory: TArmorCategory;
  public
    property SFE: Integer read FStat_SFE;
    property MGT: Integer read FStat_MGT;
    property ArmorCategory: TArmorCategory read GetArmorCategory;
  end;

  TMagicItem = class(TEquipment)
  end;

  TPoison = class(TEquipment)
  private
    FLevel: Integer;
    FDuration: Integer;
//    FPoisonCategory: TPoisonCategory;
  public
    property Level: Integer read FLevel;
    property Duration: Integer read FDuration;
//    property PoisonCategory: TPoisonCategory read FPoisonCategory;
  end;

  TPotion = class(TEquipment)
  end;

{ TSkillList class }

  TSkillList = class(TList)
  private
    FOwnsObjects: Boolean;
  protected
    procedure Notify(Ptr: Pointer; Action: TListNotification); override;
    function GetItem(Index: Integer): TSkill;
    procedure SetItem(Index: Integer; ASkill: TSkill);
  public
    constructor Create; overload;
    constructor Create(AOwnsObjects: Boolean); overload;

    function Add(ASkill: TSkill): Integer;
    function Extract(Item: TSkill): TSkill;
    function Remove(ASkill: TSkill): Integer;
    function IndexOf(ASkill: TSkill): Integer;
    function FindInstanceOf(AClass: TClass; AExact: Boolean = True; AStartAt: Integer = 0): Integer;
    procedure Insert(Index: Integer; ASkill: TSkill);
    function First: TSkill;
    function Last: TSkill;
    property OwnsObjects: Boolean read FOwnsObjects write FOwnsObjects;
    property Items[Index: Integer]: TSkill read GetItem write SetItem; default;
  end;

{ TStatList class }

  TStatList = class(TList)
  private
    FOwnsObjects: Boolean;
  protected
    procedure Notify(Ptr: Pointer; Action: TListNotification); override;
    function GetItem(Index: Integer): TStat;
    procedure SetItem(Index: Integer; AStat: TStat);
  public
    constructor Create; overload;
    constructor Create(AOwnsObjects: Boolean); overload;

    function Add(AStat: TStat): Integer;
    function Extract(Item: TStat): TStat;
    function Remove(AStat: TStat): Integer;
    function IndexOf(AStat: TStat): Integer;
    function FindInstanceOf(AClass: TClass; AExact: Boolean = True; AStartAt: Integer = 0): Integer;
    procedure Insert(Index: Integer; AStat: TStat);
    function First: TStat;
    function Last: TStat;
    property OwnsObjects: Boolean read FOwnsObjects write FOwnsObjects;
    property Items[Index: Integer]: TStat read GetItem write SetItem; default;
  end;

  TKAPRange = (krPrimaryStat, krCombatStat, krOtherStat);
  TOptions = set of (opTripleKPEnabled, opNoCharismaKAP);
  TStatChangeEvent = procedure(Sender: TObject; AStat: TStat) of object;

{ TCustomCharacter class }

  TCustomCharacter = class(TObject)
  private
    FOwner: TWinControl;
    FStats: TStatList;  // A list of TStat Objects
    FSkills: TSkillList; // A list of TSkill Objects
    FEquipment: TObjectList; // TEquipment
    FOptions: TOptions;
//    FOnStatChange: TStatChangeEvent;
    procedure AddStat(const StatNames: array of String);
    function GetModifier(const AStat: TStat; const AModifierName: String; var AModPosition: Integer): TStat;
    function GetRemainingKAP: Integer;
    function GetRemainingKP: Integer;
    function GetMaxHM(const AHMStatName: String): Integer;
    procedure LoadDefaultStats;
    procedure RemoveConnections(DoomedStat: TStat);
    procedure RemoveStat(const StatNames: array of String);
    procedure SetupConnections(ConnectingStat: TStat);
  public
    constructor Create(AOwner: TWinControl);
    destructor Destroy; override;
    procedure AddEquipment(const AEquipmentName: String; const AItemTag: Integer; const AQuantity: Integer = 1);
    procedure AddSkill(const AGlobalSkill: TSkillData; const AValue: Integer;
      const APrice: Integer; const AKAPUsed: Boolean; const ASubType: String = ''; const AReqType: TStat = nil);
    procedure EquipItem(AEquipment: TEquipment; const NewLocation: TEquipmentLocation);
    function GetEquipment(const AName: String): TEquipment;
    function GetEquipmentAtLocation(const ALocation: TEquipmentLocation): TEquipment;
    function GetPercentSkillBase(const APercentSkillName: String): TStat;
    function GetPercentSkillIncrement(const ASkillName: String): Integer;
    function GetPrimaryStatAverage: Single;
    procedure GetRequirementList(const ASkill: TSkillData; const ACheckLevel: Integer;
      var AReqList: TStringList; var AMissingReqCounter: Integer; const PerformQuickCheck: Boolean = False;
      const ASelectedSubType: String = '');
    function GetSkill(const AName: String; const GetTheGreatestValue: Boolean = False): TSkill; overload;
    function GetSkill(const AName: String; const ASubType: String): TSkill; overload;
    function GetSkillPrice(const ASkill: TSkillData; var APureCost: Integer; const ALevel: Integer = 1;
      const WantPriceSummed: Boolean = False; const ExistingSkill: TSkill = nil;
      const AUseKAP: Boolean = False): Integer;
    function GetSpentHM: Integer;
    function GetStat(const AName: String): TStat;
    function GetStatRange(const AStatName: String; const ARangeType: TRangeType): Integer;
    function GetSubType(ASkill: TSkill): String;
    function GetSumKAP(const ARange: TKAPRange): Integer;
    function GetSumKP(const AIgnoreOptions: Boolean = False): Integer;
    function GetWeapon(const AName: String): TCustomWeapon;
    function RemoveSkill(const AIndex: Integer; const ASelectionRange: Integer): Boolean;
    function SameSubTypeCategory(const SubTypeA: String; const SubTypeB: String): Boolean;
    procedure SetClass(AClassIndex: Integer);
    procedure SetRace(ARaceIndex: Integer);
    function SetStat(AStat: TStat; NewBaseValue: Integer): Boolean;
    property RemainingKAP: Integer read GetRemainingKAP;
    property RemainingKP: Integer read GetRemainingKP;
    property Stats: TStatList read FStats;
    property Skills: TSkillList read FSkills;
    property Equipment: TObjectList read FEquipment;
    property Options: TOptions read FOptions write FOptions;
//    property OnStatChange: TStatChangeEvent read FOnStatChange write FOnStatChange;
  end;

  TPlayerCharacter = class(TCustomCharacter);

//  SendMessage(FOwner.Handle, UM_STATCHANGE, 0, 0);
var
  NodeData: TStringList;
  BaseSkillData: array of TSkillData;
  BaseWeaponData: array of TWeaponData;
  BaseArmorData: array of TArmorData;
  BaseEquipmentData: array of TEquipmentData;
  PrimaryNodeMarker: TObject;
  SecondaryNodeMarker: TObject;
  RequirementIsMetMarker: TObject;

  SkillCommentLines: TStringList;
  WeaponCommentLines: TStringList;
  ArmorCommentLines: TStringList;
  EquipmentCommentLines: TStringList;

const
  SkillDataFileName = 'SkillData.dat';
  WeaponDataFileName = 'WeaponData.dat';
  ArmorDataFileName = 'ArmorData.dat';
  EquipmentDataFileName = 'EquipmentData.dat';

// This requires a typed data structure, only editable from the Editors! Do not leave it like this.
procedure LoadSkills(const FileName: String = SkillDataFileName);     // Load skills from file;
procedure LoadWeapons(const FileName: String = WeaponDataFileName);   // Load weapons from file;
procedure LoadArmor(const FileName: String = ArmorDataFileName);      // Load armor from file;
procedure LoadEquipment(const FileName: String = EquipmentDataFileName); // Load armor from file;

procedure GetComponentFromString(const AString: String; var AShortName: String; var ALongName: String; var APos: Integer);
function GetSkillData(const ASkillName: String): TSkillData;
function NameIsStat(const AName: String): Boolean;
function SkillNameIsValid(const ASkillName: String): Boolean;

////////////////////////////////////////////////////////////////////////////////
/////////////////////////////    SAVEFILE DATA    //////////////////////////////
////////////////////////////////////////////////////////////////////////////////

// Constants to identify data locations within the savefile
// (used by both character save files and editor base datafiles)

type
  TSaveData = type Cardinal;

const
//(fid = Field ID)
  fidName       = TSaveData(10000);
  fidStats      = TSaveData(10001);
  fidSkills     = TSaveData(10002);
  fidEquipment  = TSaveData(10003);

implementation

////////////////////////////////////////////////////////////////////////////////
///////////////////////////    INTERNAL VARIABLES    ///////////////////////////
////////////////////////////////////////////////////////////////////////////////
var
  PrimaryStatLow, PrimaryStatHigh: Integer;
  CombatStatLow, CombatStatHigh: Integer;
  OtherStatLow, OtherStatHigh: Integer; // These store ListPos data to save time on function calls

////////////////////////////////////////////////////////////////////////////////
/////////////////////////////    OTHER ROUTINES    /////////////////////////////
////////////////////////////////////////////////////////////////////////////////
{$message Hint 'Other routines'}
{ Private declarations }
function GetSkillDataPos(const ASkillName: String): Integer;
var SearchIndex: Integer;
begin
  Result := -1;

  for SearchIndex := 0 to Length(BaseSkillData) - 1 do
    if BaseSkillData[SearchIndex].Name = ASkillName then
      begin
        Result := SearchIndex;
        Exit;
      end;
end;

function GetWeaponDataPos(const AWeaponName: String): Integer;
var SearchIndex: Integer;
begin
  Result := -1;

  for SearchIndex := 0 to Length(BaseWeaponData) - 1 do
    if BaseWeaponData[SearchIndex].Name = AWeaponName then
      begin
        Result := SearchIndex;
        Exit;
      end;
end;

function GetArmorDataPos(const AArmorName: String): Integer;
var SearchIndex: Integer;
begin
  Result := -1;

  for SearchIndex := 0 to Length(BaseArmorData) - 1 do
    if BaseArmorData[SearchIndex].Name = AArmorName then
      begin
        Result := SearchIndex;
        Exit;
      end;
end;

function GetEquipmentDataPos(const AEquipmentName: String): Integer;
var SearchIndex: Integer;
begin
  Result := -1;

  for SearchIndex := 0 to Length(BaseEquipmentData) - 1 do
    if BaseEquipmentData[SearchIndex].Name = AEquipmentName then
      begin
        Result := SearchIndex;
        Exit;
      end;
end;

{ Public declarations }
procedure GetComponentFromString(const AString: String; var AShortName: String; var ALongName: String; var APos: Integer);
var S: String;
    Cv1: Integer;
begin
  S := AString;
  if Pos('_', AString) <> 0 then
    S := Copy(AString, 1, Pos('_', AString) - 1);

  for Cv1 := USER_STAT_LOW to USER_STAT_HIGH do
    if (ComponentIdentifiers[Cv1] = S) or (ComponentNames[Cv1] = S) then
      begin
        AShortName := ComponentIdentifiers[Cv1];
        ALongName := ComponentNames[Cv1];
        APos := Cv1;
        Exit;
      end;
end;

function GetSkillData(const ASkillName: String): TSkillData;
var TempInt: Integer;
begin
  TempInt := GetSkillDataPos(ASkillName);

  if TempInt > -1 then
    Result := BaseSkillData[TempInt];
end;

function NameIsStat(const AName: String): Boolean;
var SearchIndex: Integer;
begin
  Result := False;

  for SearchIndex := USER_STAT_LOW to USER_STAT_HIGH do
    if (ComponentNames[SearchIndex] = AName) or
       (ComponentIdentifiers[SearchIndex] = AName) then
      begin
        Result := True;
        Exit;
      end;
end;

function SkillNameIsValid(const ASkillName: String): Boolean;
begin
  Result := GetSkillDataPos(ASkillName) <> -1;
end;

////////////////////////////////////////////////////////////////////////////////
/////////////////////////    OBJECT IMPLEMENTATIONS    /////////////////////////
////////////////////////////////////////////////////////////////////////////////

{ TStat }
{ Private declarations }
constructor TStat.Create(AOwner: TCustomCharacter = nil);
begin
  inherited Create;
  FOwner := AOwner;
  FModifiers := TIntegerList.Create;
end;

destructor TStat.Destroy;
begin
  FModifiers.Free;
  inherited Destroy;
end;

procedure TStat.SetModified(const NewValue: Boolean);
begin
  DebugManager.EventList.Add('Setting <' + FName + '>''s Modified value to (' + BoolToStr(NewValue, True) + ')');

  if NewValue then
    SetBaseValue(FBaseValue);

  FModified := NewValue;
end;

procedure TStat.SetBaseValue(const NewBaseValue: Integer);
var SearchIndex, TempValue: Integer;
    NeedUpdate: Boolean;
begin
  FBaseValue := NewBaseValue;
  NeedUpdate := True;

  for SearchIndex := 0 to FModifiers.Count - 1 do
// Check if the Stat has a 'Szint' modifier and manually update it's corresponding CurrentValue
    if (FName <> 'Sebzésjárulék') and (TStat(FModifiers.Objects[SearchIndex]).FName = 'Szint') then
      begin
        FCurrentValue := NewBaseValue * FOwner.GetStat('Szint').FBaseValue;
        NeedUpdate := False;
      end;

// If there's no 'Szint' modifier, update the current value
  if NeedUpdate then
    begin
      TempValue := FBaseValue;
      for SearchIndex := 0 to FModifiers.Count - 1 do
        TempValue := TempValue + FModifiers.Integers[SearchIndex];

      FCurrentValue := TempValue;
    end;

  TempValue := FCurrentValue;
  if (opTripleKPEnabled in FOwner.FOptions) and (FName = 'KP') then
    FCurrentValue := TempValue * 3;

  if (FName = 'Pszi') then
    if (FOwner.GetStat('Pszi') <> nil) and (FOwner.GetStat('Pszi / Szint') <> nil) then
      FCurrentValue := FCurrentValue - FOwner.GetStat('Pszi / Szint').FBaseValue;

  FModified := True;

  DebugManager.EventList.Add('Setting <' + FName + '>''s base value to (' + IntToStr(FBaseValue) + ')');
  DebugManager.EventList.Add('<' + FName + '>''s current value is (' + IntToStr(FCurrentValue) + ')');

// Make other stats update their relevant data
  for SearchIndex := 0 to FOwner.FStats.Count - 1 do
    FOwner.FStats[SearchIndex].UpdateModifiers(Self);
end;

procedure TStat.UpdateModifiers(ARequestingStat: TStat);
var SearchIndex, HMValue, TempValue: Integer;
begin
// Don't need to update itself, it's been done
  if ARequestingStat = Self then Exit;

// Set ModFlags to other modified TStats that have the corresponding value
  for SearchIndex := 0 to FModifiers.Count - 1 do
    if (FModifiers.Objects[SearchIndex] is TStat) and (ARequestingStat <> nil) then
      if ARequestingStat.FName = TStat(FModifiers.Objects[SearchIndex]).FName then
        begin

          DebugManager.EventList.Add('');
          DebugManager.EventList.Add('<' + FName + '> is updating it''s <' + TStat(FModifiers.Objects[SearchIndex]).FName +
            '> modifier by the request of <' + ARequestingStat.FName + '>');

// Regular cases
          case ARequestingStat.FBaseListPos of
            0..9:
              if ARequestingStat.FCurrentValue > STATBONUSTHRESHOLD then
                FModifiers.Integers[SearchIndex] := ARequestingStat.FCurrentValue - STATBONUSTHRESHOLD
              else
                FModifiers.Integers[SearchIndex] := 0;
            17, 19, 22, 25, 35..38: // FPTSZ, KPTSZ, MPTSZ, PSZITSZ, KE-TE-VE-CE_HM
              FModifiers.Integers[SearchIndex] := ARequestingStat.FCurrentValue;
          end;

// Special cases
          if (ARequestingStat.FName = 'Erõ') and (FName = 'Sebzésjárulék') then
            if ARequestingStat.FCurrentValue > EROBONUSTHRESHOLD then
              FModifiers.Integers[SearchIndex] := ARequestingStat.FCurrentValue - EROBONUSTHRESHOLD
            else
              FModifiers.Integers[SearchIndex] := 0;

          if (ARequestingStat.FName = 'Szint') and (FName = 'Sebzésjárulék') then
            if FOwner.GetStat('Kaszt').FCurrentValue = 2 then // Fejvadász
              BaseValue := ARequestingStat.FBaseValue div 2
            else
              BaseValue := 0;

          if (ARequestingStat.FName = 'Szint') or (ARequestingStat.FName = 'Intelligencia') then
            if FOwner.GetStat('Kaszt').FCurrentValue = 5 then // Bárd
              begin
                TempValue := FOWner.GetStat('Intelligencia').FCurrentValue - STATBONUSTHRESHOLD;
                if TempValue < 0 then
                  TempValue := 0;

                FOwner.GetStat('Mana / Szint').BaseValue := TempValue; // Trigger an Update
              end;

          FModified := True;

          DebugManager.EventList.Add('<' + FName + '> is now flagged as MODIFIED');

// Force a full update on the Stat
// Check if the Stat is a 'HM' and manually correct it's value
          if Pos('_HM', FName) <> 0 then
            begin
              HMValue := FOwner.GetMaxHM(FName);
              if FCurrentValue > HMValue then
                BaseValue := HMValue
              else
                BaseValue := FBaseValue;
            end
          else
            BaseValue := FBaseValue;

        end;
end;

procedure TStat.UpdateSkillModifiers(ARequestingSkillName: String;
  const ModifierUpdateAction: TSkillUpdateModifierAction = umaUpdate);
var SearchIndex: Integer;
    TargetSkill: TSkill;
begin
  if ARequestingSkillNAme = '' then Exit;

// Set ModFlags to other modified TStats that have the corresponding value
  for SearchIndex := 0 to FModifiers.Count - 1 do
    if (FModifiers.Objects[SearchIndex] is TSkill) and (ARequestingSkillName <> '') then
      if ARequestingSkillName = TSkill(FModifiers.Objects[SearchIndex]).FName then
        begin

          DebugManager.EventList.Add('<' + FName + '> is updating it''s <' + TSkill(FModifiers.Objects[SearchIndex]).FName +
          '> modifier by the request of <' + ARequestingSkillName + '>');

// The skill is being deleted. Remove all associated modifiers then exit
          if ModifierUpdateAction = umaDelete then
            begin
              FModifiers.Objects[SearchIndex].Free;
              FModifiers.Delete(SearchIndex);
            end;

          if ModifierUpdateAction = umaUpdate then
            begin
// Get a pointer to the skill in the skill-list
              TargetSkill := FOwner.GetSkill(ARequestingSkillName);

              if TargetSkill <> nil then
                if (TargetSkill.FName = 'Fegyverhasználat') or (TargetSkill.FName = 'Fegyverdobás') then
                  if TargetSkill.FValue >= 3 then
                    FModifiers.Integers[SearchIndex] := 1
                  else
                    FModifiers.Integers[SearchIndex] := 0;

            end;

          FModified := True;

          DebugManager.EventList.Add('<' + FName + '> is now flagged as MODIFIED');

          BaseValue := FBaseValue;
        end;
end;

{ Public declarations }
function TStat.CurrentValue(const VisualUpdate: Boolean = True): Integer;
begin
  if VisualUpdate then
    FModified := False;

  if VisualUpdate then
    begin
      DebugManager.EventList.Add('<' + FName + '> is now flagged as NOT MODIFIED');
      DebugManager.EventList.Add('');
    end;

  Result := FCurrentValue;
end;

function TStat.GetKAP(const AValue: Integer = -1; const AIgnoreOptions: Boolean = False): Integer;
var TempValue: Integer;
begin
  Result := 0;

  if AValue = -1 then
    TempValue := FBaseValue
  else
    TempValue := AValue;

  case FBaseListPos of
    0..9:
      case TempValue of
        0..15: Result := TempValue;
        16..18: Result := 15 + ((TempValue - 15) * 2);
        19..20: Result := 21 + ((TempValue - 18) * 4);
      end;
    10..12, 16, 18: Result := TempValue;
    13, 15, 19: Result := TempValue * 2;
    14, 17: Result := TempValue * 3;
  end;

  if (opNoCharismaKAP in FOwner.FOptions) and (FName = 'Szépség') and (not AIgnoreOptions) then
    Result := 0;
end;

function TStat.GetModifierSum(const LeaveOutHM: Boolean = False): Integer;
var SearchIndex: Integer;
begin
  Result := 0;

  for SearchIndex := 0 to FModifiers.Count - 1 do
    if not (
       (FModifiers.Objects[SearchIndex] is TStat) and
       (AnsiContainsText(TStat(FModifiers.Objects[SearchIndex]).FShortName, '_HM')) and
       (LeaveOutHM)
    ) then
      Result := Result + FModifiers.Integers[SearchIndex];
end;

{ TSkill }
{ Private declarations }
constructor TSkill.Create(AOwner: TCustomCharacter = nil);
begin
  inherited Create;
  FRequirements := TObjectList.Create;
end;

destructor TSkill.Destroy;
begin
  FRequirements.Free;
  inherited Destroy;
end;

{ Public declarations }

// None yet

{ TCustomWeapon }
{ Pivate declarations }
function TCustomWeapon.GetDmg_Add: Integer;
begin
  Result := BaseWeaponData[FListPos].Dmg_Add;
end;

function TCustomWeapon.GetDmg_Max: Integer;
begin
  Result := BaseWeaponData[FListPos].Dmg_Max;
end;

function TCustomWeapon.GetDmg_Min: Integer;
begin
  Result := BaseWeaponData[FListPos].Dmg_Min;
end;

function TCustomWeapon.GetDoubleHanded: Boolean;
begin
  Result := BaseWeaponData[FListPos].DoubleHanded;
end;

function TCustomWeapon.GetReqType: String;
begin
  Result := BaseWeaponData[FListPos].ReqType;
end;

function TCustomWeapon.GetReqValue: Integer;
begin
  Result := BaseWeaponData[FListPos].ReqValue;
end;

function TCustomWeapon.GetTPK : Integer; // Tám / kör
begin
  Result := BaseWeaponData[FListPos].TPK;
end;

function TCustomWeapon.GetWeaponCategory: TWeaponCategory;
begin
  Result := BaseWeaponData[FListPos].Category;
end;

{ Public declarations }
function TCustomWeapon.GetDamageString(UseDiceRepresentation: Boolean = False): String;
var SearchIndex, Divider: Integer;
begin
  Result := IntToStr(Dmg_Min + Dmg_Add) + ' - ' + IntToStr(Dmg_Max + Dmg_Add);

  if UseDiceRepresentation then
    for SearchIndex := MaxDiceName downto 0 do
      begin
        Divider := StrToInt(Copy(CBC_DiceNames[SearchIndex], 2, Length(CBC_DiceNames[SearchIndex])));

        if Dmg_Max mod Divider = 0 then
          begin
            Result := IntToStr(Dmg_Max div Divider) + CBC_DiceNames[SearchIndex];
            if Dmg_Add > 0 then
              Result := Result + ' + ' + IntToStr(Dmg_Add);

            Exit;
          end;
      end;
end;

{ TArmor }
{ Pivate declarations }
function TArmor.GetArmorCategory: TArmorCategory;
begin
  Result := BaseArmorData[FListPos].Category;
end;

////////////////////////////////////////////////////////////////////////////////
///////////////////////////////    TSkillList    ///////////////////////////////
////////////////////////////////////////////////////////////////////////////////

function TSkillList.Add(ASkill: TSkill): Integer;
begin
  Result := inherited Add(ASkill);
end;

constructor TSkillList.Create;
begin
  inherited Create;
  FOwnsObjects := True;
end;

constructor TSkillList.Create(AOwnsObjects: Boolean);
begin
  inherited Create;
  FOwnsObjects := AOwnsObjects;
end;

function TSkillList.Extract(Item: TSkill): TSkill;
begin
  Result := TSkill(inherited Extract(Item));
end;

function TSkillList.FindInstanceOf(AClass: TClass; AExact: Boolean;
  AStartAt: Integer): Integer;
var
  I: Integer;
begin
  Result := -1;
  for I := AStartAt to Count - 1 do
    if (AExact and
        (Items[I].ClassType = AClass)) or
       (not AExact and
        Items[I].InheritsFrom(AClass)) then
    begin
      Result := I;
      break;
    end;
end;

function TSkillList.First: TSkill;
begin
  Result := TSkill(inherited First);
end;

function TSkillList.GetItem(Index: Integer): TSkill;
begin
  Result := inherited Items[Index];
end;

function TSkillList.IndexOf(ASkill: TSkill): Integer;
begin
  Result := inherited IndexOf(ASkill);
end;

procedure TSkillList.Insert(Index: Integer; ASkill: TSkill);
begin
  inherited Insert(Index, ASkill);
end;

function TSkillList.Last: TSkill;
begin
  Result := TSkill(inherited Last);
end;

procedure TSkillList.Notify(Ptr: Pointer; Action: TListNotification);
begin
  if OwnsObjects then
    if Action = lnDeleted then
      TSkill(Ptr).Free;
  inherited Notify(Ptr, Action);
end;

function TSkillList.Remove(ASkill: TSkill): Integer;
begin
  Result := inherited Remove(ASkill);
end;

procedure TSkillList.SetItem(Index: Integer; ASkill: TSkill);
begin
  inherited Items[Index] := ASkill;
end;

////////////////////////////////////////////////////////////////////////////////
////////////////////////////////    TStatList    ///////////////////////////////
////////////////////////////////////////////////////////////////////////////////

function TStatList.Add(AStat: TStat): Integer;
begin
  Result := inherited Add(AStat);
end;

constructor TStatList.Create;
begin
  inherited Create;
  FOwnsObjects := True;
end;

constructor TStatList.Create(AOwnsObjects: Boolean);
begin
  inherited Create;
  FOwnsObjects := AOwnsObjects;
end;

function TStatList.Extract(Item: TStat): TStat;
begin
  Result := TStat(inherited Extract(Item));
end;

function TStatList.FindInstanceOf(AClass: TClass; AExact: Boolean;
  AStartAt: Integer): Integer;
var
  I: Integer;
begin
  Result := -1;
  for I := AStartAt to Count - 1 do
    if (AExact and
        (Items[I].ClassType = AClass)) or
       (not AExact and
        Items[I].InheritsFrom(AClass)) then
    begin
      Result := I;
      break;
    end;
end;

function TStatList.First: TStat;
begin
  Result := TStat(inherited First);
end;

function TStatList.GetItem(Index: Integer): TStat;
begin
  Result := inherited Items[Index];
end;

function TStatList.IndexOf(AStat: TStat): Integer;
begin
  Result := inherited IndexOf(AStat);
end;

procedure TStatList.Insert(Index: Integer; AStat: TStat);
begin
  inherited Insert(Index, AStat);
end;

function TStatList.Last: TStat;
begin
  Result := TStat(inherited Last);
end;

procedure TStatList.Notify(Ptr: Pointer; Action: TListNotification);
begin
  if OwnsObjects then
    if Action = lnDeleted then
      TStat(Ptr).Free;
  inherited Notify(Ptr, Action);
end;

function TStatList.Remove(AStat: TStat): Integer;
begin
  Result := inherited Remove(AStat);
end;

procedure TStatList.SetItem(Index: Integer; AStat: TStat);
begin
  inherited Items[Index] := AStat;
end;

////////////////////////////////////////////////////////////////////////////////
///////////////////////////////    TCustomChar    //////////////////////////////
////////////////////////////////////////////////////////////////////////////////
{$message Hint 'TCustomChar routines'}
{ TCustomChar }
{ Private declarations }
constructor TCustomCharacter.Create(AOwner: TWinControl);
begin
  inherited Create;
  FOwner := AOwner;
  FStats := TStatList.Create;
  FSkills := TSkillList.Create;
  FEquipment := TObjectList.Create;
  FOptions := [];
// Fill up list with the basic stats and set them to default values
  LoadDefaultStats;
end;

destructor TCustomCharacter.Destroy;
begin
  FStats.Free;
  FSkills.Free;
  FEquipment.Free;
  inherited Destroy;
end;

function TCustomCharacter.GetModifier(const AStat: TStat; const AModifierName: String; var AModPosition: Integer): TStat;
var SearchIndex: Integer;
begin
  Result := nil;

  if AStat = nil then Exit;

  for SearchIndex := 0 to AStat.FModifiers.Count - 1 do
    if (TStat(AStat.FModifiers.Objects[SearchIndex]).FName = AModifierName) or
       (TStat(AStat.FModifiers.Objects[SearchIndex]).FShortName = AModifierName) then
      begin
        Result := TStat(AStat.FModifiers.Objects[SearchIndex]);
        AModPosition := SearchIndex;
        Exit;
      end;
end;

function TCustomCharacter.GetRemainingKAP: Integer;
var SearchIndex, TempInt: Integer;
begin
  TempInt := MaxKAP;
  for SearchIndex := 0 to FStats.Count - 1 do
    TempInt := TempInt - FStats[SearchIndex].GetKAP;

  for SearchIndex := 0 to FSkills.Count - 1 do
    if FSkills[SearchIndex].FKapUsed then
      TempInt := TempInt - FSkills[SearchIndex].FPrice;

  Result := TempInt;
end;

function TCustomCharacter.GetRemainingKP: Integer;
var SearchIndex, TempInt: Integer;
begin
  Result := 0;
  TempInt := GetStat('KP').FCurrentValue;

  for SearchIndex := 0 to FSkills.Count - 1 do
    if not FSkills[SearchIndex].FKapUsed then
      TempInt := TempInt - FSkills[SearchIndex].FPrice;

  if TempInt > 0 then
    Result := TempInt;
end;

function TCustomCharacter.GetMaxHM(const AHMStatName: String): Integer;
var SearchIndex, TempInt, HMLow, HMHigh: Integer;
begin
  DebugManager.EventList.Add('Requesting HM data');

  TempInt := 0;

  HMLow := GetStat('KE_HM').FBaseListPos;
  HMHigh := GetStat('CE_HM').FBaseListPos;

  for SearchIndex := HMLow to HMHigh do
    if AHMStatName <> ComponentIdentifiers[SearchIndex] then
      TempInt := TempInt + GetStat(ComponentIdentifiers[SearchIndex]).FCurrentValue;

  Result := GetStat('HM / Szint').FCurrentValue - TempInt;

  if Result < 0 then Result := 0;

  DebugManager.EventList.Add('Calculating max HM value for <' + AHMStatName + '>, value: (' + IntToStr(Result) + ')');

end;

procedure TCustomCharacter.AddStat(const StatNames: array of String);
var SearchIndex, StatPosInList, ArrayPos, ArrayLength: Integer;
begin
  ArrayLength := Length(StatNames);
  if ArrayLength = 0 then Exit;

  for ArrayPos := 0 to ArrayLength do
    for SearchIndex := USER_STAT_LOW to USER_STAT_HIGH do
      if (ComponentNames[SearchIndex] = StatNames[ArrayPos]) or
         (ComponentIdentifiers[SearchIndex] = StatNames[ArrayPos]) then
        begin
          DebugManager.EventList.Add('Adding Stat <' + ComponentNames[SearchIndex] + '> to character');

          StatPosInList := FStats.Add(TStat.Create(Self));
          FStats[StatPosInList].FName := ComponentNames[SearchIndex];
          FStats[StatPosInList].FShortName := ComponentIdentifiers[SearchIndex];
          FStats[StatPosInList].FBaseValue := ComponentRange[SearchIndex, stDefault];
          FStats[StatPosInList].FCurrentValue := FStats[StatPosInList].FBaseValue;
          FStats[StatPosInList].FBaseListPos := SearchIndex;
          FStats[StatPosInList].FListPos := StatPosInList;
        end;
end;

procedure TCustomCharacter.LoadDefaultStats;
var SearchIndex: Integer;
begin
  DebugManager.EventList.Add('Loading default character settings');

  AddStat(['Erõ','Gyorsaság','Ügyesség','Állóképesség','Egészség',
           'Szépség','Intelligencia','Akaraterõ','Asztrál','Érzékelés',
           'KÉ','TÉ','VÉ','CÉ','HM / Szint','ÉP','FP','FP / Szint','KP','KP / Szint',
           'Szint','AME','MME','Sebzésjárulék','Nem','Jellem','Faj','Kaszt','Szülõföld','Vallás','Életkor',
           'KÉ-re osztott HM','TÉ-re osztott HM','VÉ-re osztott HM','CÉ-re osztott HM']);

  for SearchIndex := 0 to FStats.Count - 1 do
    SetupConnections(FStats[SearchIndex]);

// Fill up internal variable Data
  DebugManager.EventList.Add('');
  DebugManager.EventList.Add('Filling internal ListPos variable data');

  PrimaryStatLow := GetStat('Erõ').FBaseListPos;
  PrimaryStatHigh := GetStat('Érzékelés').FBaseListPos;

  CombatStatLow := GetStat('KÉ').FBaseListPos;
  CombatStatHigh := GetStat('HM / Szint').FBaseListPos;

  OtherStatLow := GetStat('ÉP').FBaseListPos;
  OtherStatHigh := GetStat('KP / Szint').FBaseListPos;

  DebugManager.EventList.Add('Default character settings loaded');
  DebugManager.EventList.Add('');
end;

procedure TCustomCharacter.RemoveConnections(DoomedStat: TStat);
var SearchIndex, ModIndex: Integer;
    SearchName: String;
begin
  SearchName := '';
  for SearchIndex := 0 to FStats.Count - 1 do
    for ModIndex := 0 to FStats[SearchIndex].FModifiers.Count - 1 do
      begin
        if FStats[SearchIndex].FModifiers.Objects[ModIndex] is TStat then
          SearchName := TStat(FStats[SearchIndex].FModifiers.Objects[ModIndex]).FName;

        if FStats[SearchIndex].FModifiers.Objects[ModIndex] is TSkill then
          SearchName := TSkill(FStats[SearchIndex].FModifiers.Objects[ModIndex]).FName;

        if SearchName = DoomedStat.FName then
          begin
            FStats[SearchIndex].FModifiers.Delete(ModIndex);

            DebugManager.EventList.Add('Removing connection for <' + DoomedStat.FName + '> from <' +
              FStats[SearchIndex].FName + '> at modposition (' + IntToStr(ModIndex) + ')');
          end;
      end;
end;

procedure TCustomCharacter.RemoveStat(const StatNames: array of String);
var SearchIndex, ArrayPos, ArrayLength: Integer;
begin
  ArrayLength := Length(StatNames);
  if ArrayLength = 0 then Exit;

  for ArrayPos := 0 to ArrayLength - 1 do
    begin
      SearchIndex := 0;

      while SearchIndex < FStats.Count do
        if (FStats[SearchIndex].FName = StatNames[ArrayPos]) or
           (FStats[SearchIndex].FShortName = StatNames[ArrayPos]) then
          begin
            DebugManager.EventList.Add('Removing Stat <' + ComponentNames[SearchIndex] + '> from character');

            RemoveConnections(FStats[SearchIndex]);

            FStats.Delete(SearchIndex);
          end
        else
          Inc(SearchIndex);
    end;
end;

procedure TCustomCharacter.SetupConnections(ConnectingStat: TStat);
var ModPos: Integer;
begin
  DebugManager.EventList.Add('');
  DebugManager.EventList.Add('Setting up connections for <' + ConnectingStat.FName + '>');

  if (ConnectingStat.FName = 'Erõ') or
     (ConnectingStat.FName = 'Gyorsaság') or
     (ConnectingStat.FName = 'Ügyesség') or
     (ConnectingStat.FName = 'Állóképesség') or
     (ConnectingStat.FName = 'Egészség') or
     (ConnectingStat.FName = 'Szépség') or
     (ConnectingStat.FName = 'Intelligencia') or
     (ConnectingStat.FName = 'Asztrál') or
     (ConnectingStat.FName = 'Érzékelés') then
    if GetModifier(ConnectingStat, 'Faj', ModPos) = nil then
      ConnectingStat.FModifiers.AddObject(0, GetStat('Faj'));

  if ConnectingStat.FName = 'KÉ' then
    begin
      ConnectingStat.FModifiers.AddObject(0, GetStat('Gyorsaság'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('Ügyesség'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('KE_HM'));
    end;

  if ConnectingStat.FName = 'TÉ' then
    begin
      ConnectingStat.FModifiers.AddObject(0, GetStat('Erõ'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('Gyorsaság'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('Ügyesség'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('TE_HM'));
    end;

  if ConnectingStat.FName = 'VÉ' then
    begin
      ConnectingStat.FModifiers.AddObject(0, GetStat('Gyorsaság'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('Ügyesség'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('VE_HM'));
    end;

  if ConnectingStat.FName = 'CÉ' then
    begin
      ConnectingStat.FModifiers.AddObject(0, GetStat('Ügyesség'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('CE_HM'));
    end;

  if ConnectingStat.FName = 'HM / Szint' then
    ConnectingStat.FModifiers.AddObject(0, GetStat('Szint'));

  if ConnectingStat.FName = 'ÉP' then
    ConnectingStat.FModifiers.AddObject(0, GetStat('Egészség'));

  if ConnectingStat.FName = 'FP' then
    begin
      ConnectingStat.FModifiers.AddObject(0, GetStat('Állóképesség'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('Akaraterõ'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('FP / Szint'));
    end;

  if ConnectingStat.FName = 'FP / Szint' then
    ConnectingStat.FModifiers.AddObject(0, GetStat('Szint'));

  if ConnectingStat.FName = 'KP' then
    begin
      ConnectingStat.FModifiers.AddObject(0, GetStat('Ügyesség'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('Intelligencia'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('KP / Szint'));
    end;

  if ConnectingStat.FName = 'KP / Szint' then
    ConnectingStat.FModifiers.AddObject(0, GetStat('Szint'));

  if ConnectingStat.FName = 'Mana' then
    ConnectingStat.FModifiers.AddObject(0, GetStat('Mana / Szint'));

  if ConnectingStat.FName = 'Mana / Szint' then
    ConnectingStat.FModifiers.AddObject(0, GetStat('Szint'));

  if ConnectingStat.FName = 'Sebzésjárulék' then
    begin
      ConnectingStat.FModifiers.AddObject(0, GetStat('Erõ'));
    end;

  if ConnectingStat.FName = 'Pszi' then
    begin
      ConnectingStat.FModifiers.AddObject(0, GetStat('Intelligencia'));
      ConnectingStat.FModifiers.AddObject(0, GetStat('Pszi / Szint'));
    end;

  if ConnectingStat.FName = 'Pszi / Szint' then
    ConnectingStat.FModifiers.AddObject(0, GetStat('Szint'));

  if ConnectingStat.FName = 'Asztrális Mágiaellenállás' then
    ConnectingStat.FModifiers.AddObject(0, GetStat('Asztrál'));

  if ConnectingStat.FName = 'Mentális Mágiaellenállás' then
    ConnectingStat.FModifiers.AddObject(0, GetStat('Akaraterõ'));

  if (ConnectingStat.FName = 'KÉ-re osztott HM') or
     (ConnectingStat.FName = 'TÉ-re osztott HM') or
     (ConnectingStat.FName = 'VÉ-re osztott HM') or
     (ConnectingStat.FName = 'CÉ-re osztott HM') then
    ConnectingStat.FModifiers.AddObject(0, GetStat('HM / Szint'));

end;

{ Public declarations }
procedure TCustomCharacter.AddEquipment(const AEquipmentName: String; const AItemTag: Integer; const AQuantity: Integer = 1);
var
  ListPos, BasePos: Integer;
  EquipName: String;
begin
  if GetEquipment(AEquipmentName) = nil then
    case AItemTag of
      Tag_Weapon:
        begin
          ListPos := FEquipment.Add(TCustomWeapon.Create);
          BasePos := GetWeaponDataPos(AEquipmentName);
          EquipName := BaseWeaponData[BasePos].Name;

          with TCustomWeapon(FEquipment[ListPos]) do
            begin
              FOwner := Self;
              FName := EquipName;
              FListPos := BasePos;
              FAmount := AQuantity;
              FLocation := elBackPack;
              FCategory := ecWeapon;
            end;
        end;
      Tag_Armor:
        begin
          ListPos := FEquipment.Add(TArmor.Create);
          BasePos := GetArmorDataPos(AEquipmentName);
          EquipName := BaseArmorData[BasePos].Name;

          with TArmor(FEquipment[ListPos]) do
            begin
              FOwner := Self;
              FName := EquipName;
              FListPos := BasePos;
              FAmount := AQuantity;
              FLocation := elBackPack;
              FCategory := ecArmor;
            end;
        end;
      Tag_Equipment_General, Tag_Equipment_Poison, Tag_Equipment_Potion, Tag_Equipment_MagicItem:
        begin
          ListPos := FEquipment.Add(TEquipment.Create);
          BasePos := GetEquipmentDataPos(AEquipmentName);
          EquipName := BaseEquipmentData[BasePos].Name;

          with TEquipment(FEquipment[ListPos]) do
            begin
              FOwner := Self;
              FName := EquipName;
              FListPos := BasePos;
              FAmount := AQuantity;
              FLocation := elBackPack;
              FCategory := BaseEquipmentData[BasePos].Category;
            end;
        end;
    end;
end;

procedure TCustomCharacter.AddSkill(const AGlobalSkill: TSkillData; const AValue: Integer;
  const APrice: Integer; const AKAPUsed: Boolean; const ASubType: String = ''; const AReqType: TStat = nil);
var SearchIndex, SkillPos, SpecValue: Integer;
    SpecName: String;

  procedure CreateModifier(SpecStat: TStat);
  var ModIndex, SpecPos: Integer;
  begin
    DebugManager.EventList.Add('Searching for skill modifiers...');

 // If the modifier already exists then do nothing
    for ModIndex := 0 to SpecStat.FModifiers.Count - 1 do
      if SpecStat.FModifiers.Objects[ModIndex] is TSkill then
        if TSkill(SpecStat.FModifiers.Objects[ModIndex]).FName = SpecName then
          Exit;

// Put in new object, name it apprpriately, then refresh
    SpecPos := SpecStat.FModifiers.AddObject(0, TSkill.Create(Self));
    TSkill(SpecStat.FModifiers.Objects[SpecPos]).FName := SpecName;

    DebugManager.EventList.Add('New modifier created for <' + SpecStat.FName + '> at position (' + IntToStr(SpecPos) + ')');

    SpecStat.UpdateSkillModifiers(AGlobalSkill.Name);
  end;

begin
  DebugManager.EventList.Add('');
  DebugManager.EventList.Add('Adding/overwriting a skill <' + AGlobalSkill.Name + '>');

  // If the skill is already in the list, overwrite it
  SkillPos := -1;
  SpecName := '';
  SpecValue := 0;

  for SearchIndex := 0 to FSkills.Count - 1 do
    if (FSkills[SearchIndex].FName = AGlobalSkill.Name) and (FSkills[SearchIndex].FSubType = ASubType) then
      begin
        SkillPos := SearchIndex;
        Break;
      end;

  if (SkillPos <> SearchIndex) or (SkillPos = -1) then
    SkillPos := FSkills.Add(TSkill.Create(Self));

// MAGIC STARTS HERE
  with FSkills[SkillPos] do
    begin
      FName := AGlobalSkill.Name;
      SpecName := FName;

      FValue := AValue;
      SpecValue := FValue;

      FRequirements := nil;
      FPrice := APrice;
//      FRequirements := AGlobalSkill.FRequirements; // THIS LINE CAUSES ACCESS VIOLATIONS AT TERMINATION 'COS TWO LISTS TRY TO FREE IT!
      FModified := True;
      FPercentSkill := AGlobalSkill.IsPercentSkill;
      FKapUsed := AKAPUsed;
      FSubType := ASubType;
      FSubTypeRefSkill := AGlobalSkill.SubTypeRefSkill;
    end;

// Create special modifiers
  if ((SpecName = 'Fegyverhasználat') or (SpecName = 'Fegyverdobás')) and
     (AReqType <> nil) then
    begin
// Create a modifier object for the Primary stat of AReqType
      CreateModifier(AReqType);
//      CreateModifier(GetStat('KÉ'));
    end;

  if SpecName = 'Pszi' then
    begin
      if GetStat('Pszi') = nil then
        begin
          AddStat(['Pszi','Pszi / Szint']);
          SetupConnections(GetStat('Pszi'));
          SetupConnections(GetStat('Pszi / Szint'));
          with GetStat('Intelligencia') do
            BaseValue := FBaseValue; // Trigger a Modifier update
        end;

      case GetStat('Kaszt').FCurrentValue of
        0..7, 10..12:
          if SpecValue < 4 then
            begin
              GetStat('Pszi').BaseValue := 4;
              GetStat('Pszi / Szint').BaseValue := 3;
            end
          else
            begin
              GetStat('Pszi').BaseValue := 5;
              GetStat('Pszi / Szint').BaseValue := 4;
            end;
        8..9:
            begin
              GetStat('Pszi').BaseValue := 6;
              GetStat('Pszi / Szint').BaseValue := 5;
            end;
        13:
            begin
              GetStat('Pszi').BaseValue := 7;
              GetStat('Pszi / Szint').BaseValue := 6;
            end;
      end;
    end;
end;

procedure TCustomCharacter.EquipItem(AEquipment: TEquipment; const NewLocation: TEquipmentLocation);
var Equipped: TEquipment;
begin
  Equipped := GetEquipmentAtLocation(NewLocation);

  if Equipped = AEquipment then Exit;

  if Equipped <> nil then
    begin
      DebugManager.EventList.Add('Removing an equipped <' + Equipped.FName + '>');

      Equipped.FLocation := elBackPack;
    end;

  if (NewLocation = elRightHand) and (AEquipment is TCustomWeapon) and (TCustomWeapon(AEquipment).DoubleHanded) then
    begin
      Equipped := GetEquipmentAtLocation(elLeftHand);

      if Equipped <> nil then
        begin
          Equipped.FLocation := elBackPack;
          DebugManager.EventList.Add('Equipment is doublehanded. Removing an equipped shield <' + Equipped.FName + '>');
        end;
    end;

  if NewLocation = elLeftHand then
    begin
      Equipped := GetEquipmentAtLocation(elRightHand);

      if (Equipped <> nil) and (Equipped is TCustomWeapon) and (TCustomWeapon(Equipped).DoubleHanded) then
        begin
          Equipped.FLocation := elBackPack;

          DebugManager.EventList.Add('Equipment is a shield. Removing an equipped doublehanded weapon <' + Equipped.FName + '>');
        end;
    end;

  AEquipment.FLocation := NewLocation;

  DebugManager.EventList.Add('Equipped a <' + AEquipment.FName + '>');
end;

function TCustomCharacter.GetEquipment(const AName: String): TEquipment;
var SearchIndex: Integer;
begin
  Result := nil;
  for SearchIndex := 0 to FEquipment.Count - 1 do
    if TEquipment(FEquipment[SearchIndex]).FName = AName then
      begin
        Result := TEquipment(FEquipment[SearchIndex]);

        DebugManager.EventList.Add('Character requesting TEquipment data on <' + Result.FName + '>');

        Exit;
      end;
end;

function TCustomCharacter.GetEquipmentAtLocation(const ALocation: TEquipmentLocation): TEquipment;
var SearchIndex: Integer;
begin
  Result := nil;

  for SearchIndex := 0 to FEquipment.Count - 1 do
    if TEquipment(FEquipment[SearchIndex]).FLocation = ALocation then
      begin
        Result := TEquipment(FEquipment[SearchIndex]);
        Exit;
      end;
end;

function TCustomCharacter.GetPercentSkillBase(const APercentSkillName: String): TStat;
var LevelIndex, SearchIndex, GreatestValue: Integer;
    GreatestStat, TempStat: TStat;
    TempReq: TReqData;
    TempData: TSkillData;
begin
  Result := nil;
  GreatestStat := nil;
  GreatestValue := 0;

  TempData := GetSkillData(APercentSkillName);
  if not TempData.IsPercentSkill then Exit;

// Search for TStat references
  for LevelIndex := 0 to Length(TempData.Levels) - 1 do
    for SearchIndex := 0 to Length(TempData.Levels[LevelIndex].Requirements) - 1 do
      begin
        TempReq := TempData.Levels[LevelIndex].Requirements[SearchIndex];

        if TempReq.IsStat then
          begin
            TempStat := GetStat(TempReq.ReqName);

            if TempStat <> nil then
              if TempStat.FBaseValue > GreatestValue then
                begin
                  GreatestValue := TempStat.FBaseValue;
                  GreatestStat := TempStat;
                end;
          end;
      end;

  Result := GreatestStat;

  DebugManager.EventList.Add('Character requesting <' + APercentSkillName + '>''s percentskillbase (' + Result.FName + ')');

end;

function TCustomCharacter.GetPercentSkillIncrement(const ASkillName: String): Integer;
var SearchIndex: Integer;
    TempSkill: TSkillData;
begin
  Result := 0;
  if ASkillName = '' then Exit;

  TempSkill := GetSkillData(ASkillName);
  if not TempSkill.IsPercentSkill then Exit;

  for SearchIndex := 0 to Length(TempSkill.Levels) - 1 do
    begin
      Result := TempSkill.Levels[SearchIndex].Price mod 10;
      Break;
    end;
end;

function TCustomCharacter.GetPrimaryStatAverage: Single;
var SearchIndex: Integer;
begin
  DebugManager.EventList.Add('Character requesting a Primary Stat Average check');

  Result := 0;
  for SearchIndex := PrimaryStatLow to PrimaryStatHigh do
    Result := Result + FStats[SearchIndex].FCurrentValue;

  Result := Result / 10;
end;

function ReqListSortCompare(AList: TStringList; IndexA, IndexB: Integer): Integer;
var AIsStat, BIsStat: Boolean;
    AStr, BStr: String;
begin
  AStr := Copy(AList[IndexA], 1, Pos(';', AList[IndexA]) - 1);
  BStr := Copy(AList[IndexB], 1, Pos(';', AList[IndexB]) - 1);

  DebugManager.EventList.Add('AStr: ' + AStr + '; BStr: ' + BStr);

  AIsStat := NameIsStat(AStr);
  BIsStat := NameIsStat(BStr);

  Result := 0;

  if AIsStat and not BIsStat then
    Result := -1;

  if not AIsStat and BIsStat then
    Result := 1;

  if AIsStat and BIsStat then
    Result := AnsiCompareText(AStr, BStr);

  if not AIsStat and not BIsStat then
    Result := AnsiCompareText(AStr, BStr);
end;

procedure TCustomCharacter.GetRequirementList(const ASkill: TSkillData; const ACheckLevel: Integer; // ACheckLevel 1..5!
  var AReqList: TStringList; var AMissingReqCounter: Integer; const PerformQuickCheck: Boolean = False;
  const ASelectedSubType: String = '');
type
  TReqStatus = (NotInList, InListLowerReq, InListSameReq); // Add; Overwrite; Do nothing;
var
  CheckLevel, LevelIndex, SearchIndexA, SearchIndexB, SearchIndexC, ItemPos: Integer;
  TempReq: TReqData;
  TempStat: TStat;
  TempSkill, SubTypeCheck: TSkill;
  TempReqStr, StrA, StrB, IntA, IntB: String;
  ConditionsAreMet: Boolean;
  ReqStatus: TReqStatus;
begin
  AReqList.Clear;
  AMissingReqCounter := 0;
  TempReqStr := '';

  SubTypeCheck := GetSkill(ASkill.Name);
  CheckLevel := ACheckLevel;

  DebugManager.EventList.Add('');
  DebugManager.EventList.Add('GetRequirements for <' + ASkill.Name + '>');

  for LevelIndex := Length(ASkill.Levels) - 1 downto 0 do
    if ASkill.Levels[LevelIndex].ValidFromLevel <= CheckLevel then
    for SearchIndexA := Length(ASkill.Levels[LevelIndex].Requirements) - 1 downto 0 do
      begin
        TempReq := ASkill.Levels[LevelIndex].Requirements[SearchIndexA];
        TempReqStr := TempReq.ReqName + ';' + IntToStr(TempReq.ReqValue);

        ReqStatus := NotInList;
        SearchIndexC := 0;
        ItemPos := 0;
        ConditionsAreMet := False;

        for SearchIndexC := 0 to AReqList.Count - 1 do
          if AnsiContainsText(AReqList[SearchIndexC], TempReq.ReqName) then
            if StrToInt(Copy(TempReqStr, Pos(';', TempReqStr) + 1, Length(TempReqStr) + 1)) < TempReq.ReqValue then
              begin
                ReqStatus := InListLowerReq;
                ItemPos := SearchIndexC;
                Break;
              end
            else
              begin
                ReqStatus := InListSameReq;
                ItemPos := SearchIndexC;
                Break;
              end;

        if ReqStatus = InListSameReq then
          Continue;

        if ReqStatus = NotInList then
          ItemPos := AReqList.AddObject(TempReqStr, nil);

// Check if the STAT requirement is met and add appropriate value
        if TempReq.IsStat then
          begin
            TempStat := GetStat(TempReq.ReqName);

            if TempStat <> nil then
              if TempStat.FCurrentValue >= TempReq.ReqValue then
                AReqList.Objects[ItemPos] := RequirementIsMetMarker
              else
                AReqList.Objects[ItemPos] := nil;
          end
        else
// Check if the SKILL requirement is met and add appropriate value
          begin
            if ASelectedSubType <> '' then
              TempSkill := GetSkill(TempReq.ReqName, ASelectedSubType)
            else
              TempSkill := GetSkill(TempReq.ReqName, True);

            if (TempSkill <> nil) and (TempSkill.FValue >= TempReq.ReqValue) then
              ConditionsAreMet := True;

            if ConditionsAreMet then
              AReqList.Objects[ItemPos] := RequirementIsMetMarker
            else
              AReqList.Objects[ItemPos] := nil;
          end;

      end;

// Finally, a little aesthetic sorting
  if not PerformQuickCheck then
    AReqList.CustomSort(ReqListSortCompare);

  for SearchIndexA := 0 to AReqList.Count - 1 do
    if AReqList.Objects[SearchIndexA] = nil then
      Inc(AMissingReqCounter);
end;

function TCustomCharacter.GetSkill(const AName: String; const GetTheGreatestValue: Boolean = False): TSkill;
var SearchIndex, GreatestValue, GreatestPos: Integer;
begin
  DebugManager.EventList.Add('Character requesting TSkill data on <' + AName + '>');

  Result := nil;
  GreatestValue := 0;
  GreatestPos := 0;

  for SearchIndex := 0 to FSkills.Count - 1 do
    if FSkills[SearchIndex].FName = AName then
      begin
        if FSkills[SearchIndex].FValue > GreatestValue then
          begin
            GreatestValue := FSkills[SearchIndex].FValue;
            GreatestPos := SearchIndex;
          end;

        Result := FSkills[GreatestPos];

        if not GetTheGreatestValue then
          Exit;
      end;
end;

function TCustomCharacter.GetSkill(const AName: String; const ASubType: String): TSkill;
var SearchIndex: Integer;
    CanProceed: Boolean;
begin
  Result := nil;

  for SearchIndex := 0 to FSkills.Count - 1 do
    if FSkills[SearchIndex].FName = AName then
      begin
        if SameSubTypeCategory(ASubType, FSkills[SearchIndex].FSubType) then
          if FSkills[SearchIndex].FSubType = ASubType then
            CanProceed := True
          else
            CanProceed := False
        else
          CanProceed := True;

        if CanProceed then
          begin
            Result := FSkills[SearchIndex];

            DebugManager.EventList.Add('Character requesting SubType specific TSkill data on <' + Result.FName + '>');

            Exit;
         end;
      end;
end;

function TCustomCharacter.GetSkillPrice(const ASkill: TSkillData; var APureCost: Integer; const ALevel: Integer = 1;
  const WantPriceSummed: Boolean = False; const ExistingSkill: TSkill = nil;
  const AUseKAP: Boolean = False): Integer;
var SearchIndex, CurrentValue: Integer;
begin
// ALevel has a Range of 1..5 !!
// WantPriceSummed means that we get the TOTAL skill price summed until ALevel

  DebugManager.EventList.Add('Character requesting skillprice update');

  CurrentValue := 0;

  if not AUseKAP then
    for SearchIndex := 0 to Length(ASkill.Levels) - 1 do
      if ASkill.IsPercentSkill then
        CurrentValue := ASkill.Levels[SearchIndex].Price
      else
        if WantPriceSummed then
          if ASkill.Levels[SearchIndex].ValidFromLevel <= ALevel then
            CurrentValue := CurrentValue + ASkill.Levels[SearchIndex].Price
          else
            Break
        else
          if ASkill.Levels[SearchIndex].ValidFromLevel = ALevel then
            begin
              CurrentValue := ASkill.Levels[SearchIndex].Price;
              Break;
            end;

// Modify value if it's a PercntSkill
  if (ASkill.IsPercentSkill) and (not AUseKAP) then
    CurrentValue := (ALevel div (CurrentValue mod 10)) * Trunc(CurrentValue / 10);

// If KAP is used, now is the time to implement it's value
  if AUseKAP then
    CurrentValue := ALevel;

// Save the pure skill price
  APureCost := CurrentValue;

// Subtract ExistingSkill's price only if it's the same type as Self (indicated by AUseKAP)
  if ExistingSkill <> nil then
    if not (ExistingSkill.FKapUsed xor AUseKAP) then
      CurrentValue := CurrentValue - ExistingSkill.FPrice;

  Result := CurrentValue;
end;

function TCustomCharacter.GetSpentHM: Integer;
var TempInt: Integer;
begin
  DebugManager.EventList.Add('Character requesting spent HM');

  Result := 0;
  TempInt := 0;

  TempInt :=
    GetStat('KE_HM').FCurrentValue +
    GetStat('TE_HM').FCurrentValue +
    GetStat('VE_HM').FCurrentValue +
    GetStat('CE_HM').FCurrentValue;

  Result := TempInt;
end;

function TCustomCharacter.GetStat(const AName: String): TStat;
var SearchIndex: Integer;
begin
  DebugManager.EventList.Add('Character requesting TStat data on <' + AName + '>');

  Result := nil;
  for SearchIndex := 0 to FStats.Count - 1 do
    if (LowerCase(FStats[SearchIndex].FName) = LowerCase(AName)) or
       (LowerCase(FStats[SearchIndex].FShortName) = LowerCase(AName)) then
      begin
        Result := FStats[SearchIndex];
        Exit;
      end;

  DebugManager.EventList.Add('Unable to find matching TStat for identifier ''' + AName + '''');
end;

function TCustomCharacter.GetStatRange(const AStatName: String; const ARangeType: TRangeType): Integer;
var SearchIndex: Integer;
begin
  Result := 0;
  for SearchIndex := USER_STAT_LOW to USER_STAT_HIGH do
    if (AStatName = ComponentIdentifiers[SearchIndex]) or (AStatName = ComponentNames[SearchIndex]) then
      begin
        if (Pos('_HM', AStatName) <> 0) and (ARangeType = stMAX) then
          Result := GetMaxHM(AStatName)
        else
          Result := ComponentRange[SearchIndex, ARangeType];
        Exit;
      end;

  DebugManager.EventList.Add('Character requesting StatRange on <' + AStatName + '>, the Result is (' + IntToStr(Result) + ')');

end;

function TCustomCharacter.GetSubType(ASkill: TSkill): String;
var SearchIndex: Integer;
begin
  DebugManager.EventList.Add('');
  DebugManager.EventList.Add('Character requesting subtype for <' + ASkill.FName + '>');

  Result := '';
  if ASkill.FSubTypeRefSkill <> '' then
    begin
      for SearchIndex := 0 to FSkills.Count - 1 do
        if (FSkills[SearchIndex].FName = ASkill.FSubTypeRefSkill) and
           (FSkills[SearchIndex].SubType = ASkill.SubType) then
          begin
            Result := FSkills[SearchIndex].FSubType;
            Break;
          end;
    end
  else
    if ASkill.FSubType <> '' then
      Result := ASkill.FSubType;

  DebugManager.EventList.Add('Subtype result value: ' + Result);

end;

function TCustomCharacter.GetSumKAP(const ARange: TKAPRange): Integer;
var SearchIndex: Integer;
    DebugText: String;
begin

  Result := 0;
  case ARange of
    krPrimaryStat:
      for SearchIndex := PrimaryStatLow to PrimaryStatHigh do
        Result := Result + FStats[SearchIndex].GetKAP;

    krCombatStat:
      for SearchIndex := CombatStatLow to CombatStatHigh do
        Result := Result + FStats[SearchIndex].GetKAP;

    krOtherStat:
      for SearchIndex := OtherStatLow to OtherStatHigh do
        Result := Result + FStats[SearchIndex].GetKAP;
  end;

  DebugText := '';
  case ARange of
    krPrimaryStat: DebugText := 'krPrimaryStat';
    krCombatStat: DebugText := 'krCombatStat';
    krOtherStat: DebugText := 'krOtherStat';
  end;
  DebugManager.EventList.Add('Character requesting remaining KAP value for ID (' + DebugText + ')');
end;

function TCustomCharacter.GetSumKP(const AIgnoreOptions: Boolean = False): Integer;
var SearchIndex: Integer;
begin
  if AIgnoreOptions then
    DebugManager.EventList.Add('Character requesting untripled KP value')
  else
    DebugManager.EventList.Add('Character requesting remaining KP');

  Result := 0;

  for SearchIndex := 0 to FSkills.Count - 1 do
    if not FSkills[SearchIndex].FKapUsed then
      Result := Result + FSkills[SearchIndex].FPrice;

  if AIgnoreOptions then
    Result := GetStat('KP').FCurrentValue div 3;
end;

function TCustomCharacter.GetWeapon(const AName: String): TCustomWeapon;
var SearchIndex: Integer;
begin
  DebugManager.EventList.Add('');
  DebugManager.EventList.Add('Character requesting TCustomWeapon data on <' + AName + '>');

  Result := nil;
  for SearchIndex := 0 to FEquipment.Count - 1 do
    if (FEquipment[SearchIndex] is TCustomWeapon) and (TCustomWeapon(FEquipment[SearchIndex]).FName = AName) then
        begin
          Result := TCustomWeapon(FEquipment[SearchIndex]);
          Exit;
        end;
end;

function TCustomCharacter.RemoveSkill(const AIndex: Integer; const ASelectionRange: Integer): Boolean;
var
  SearchIndex, HighPoint: Integer;

  procedure RemoveSkillObject(ASkillPosition: Integer);
  var UpdateIndex: Integer;
      DoomedSkill: TSkill;
  begin
    DoomedSkill := FSkills[ASkillPosition];

    if DoomedSkill.FName = 'Pszi' then
      if (GetStat('Pszi') <> nil) and (GetStat('Pszi / Szint') <> nil) then
        RemoveStat(['Pszi / Szint','Pszi']);

    DebugManager.EventList.Add('Removing skill <' + DoomedSkill.FName + '>');

// Make other stats update their relevant data
    for UpdateIndex := 0 to FStats.Count - 1 do
      FStats[UpdateIndex].UpdateSkillModifiers(DoomedSkill.FName, umaDelete);

    FSkills.Delete(ASkillPosition);
  end;

begin
  Result := False;
  HighPoint := ASelectionRange;

  if AIndex <= FSkills.Count - 1 then
// If every item is selected in the list
    if FSkills.Count = ASelectionRange then
      while FSkills.Count > 0 do
        RemoveSkillObject(SearchIndex)

    else
// Delete only the selected ones
      while AIndex <= HighPoint do
        begin
          RemoveSkillObject(HighPoint);
          Dec(HighPoint);
        end;

end;

function TCustomCharacter.SameSubTypeCategory(const SubTypeA: String; const SubTypeB: String): Boolean;
var
  SearchIndex: Integer;
  CatA, CatB: String;

  function CheckResult: Boolean;
  begin
    Result := False;

    if CatA = CatB then
      Result := True;
  end;

  procedure SearchList(const AList: array of String; const CategoryName: String);
  var SubIndex: Integer;
  begin
    for SubIndex := 0 to Length(AList) - 1 do
      begin
        if AList[SubIndex] = SubTypeA then
          CatA := CategoryName;
        if AList[SubIndex] = SubTypeB then
          CatB := CategoryName;
      end;
  end;

begin
  Result := True;
  CatA := SubTypeA;
  CatB := SubTypeB;

  if CheckResult then Exit;

  for SearchIndex := 0 to Length(BaseWeaponData) - 1 do
    begin
      if BaseWeaponData[SearchIndex].Category in [wcCleave, wcPiere, wcBlunt, wcPolearm, wcRanged, wcOther] then
        begin
          if BaseWeaponData[SearchIndex].Name = SubTypeA then
            CatA := 'Fegyverhasználat';
          if BaseWeaponData[SearchIndex].Name = SubTypeB then
            CatB := 'Fegyverhasználat';
        end;

      if BaseWeaponData[SearchIndex].Category = wcThrown then
        begin
          if BaseWeaponData[SearchIndex].Name = SubTypeA then
            CatA := 'Fegyverdobás';
          if BaseWeaponData[SearchIndex].Name = SubTypeB then
            CatB := 'Fegyverdobás';
        end;

      if BaseWeaponData[SearchIndex].Category = wcFirearm then
        begin
          if BaseWeaponData[SearchIndex].Name = SubTypeA then
            CatA := 'Tûzfegyver';
          if BaseWeaponData[SearchIndex].Name = SubTypeB then
            CatB := 'Tûzfegyver';
        end;
    end;
  if CheckResult then Exit;

  SearchList(CBC_LanguageStrings, 'Élõ Nyelv');
  if CheckResult then Exit;

  SearchList(CBC_OccupationStrings, 'Iparûzés');
  if CheckResult then Exit;

  SearchList(CBC_AnimalStrings, 'Állatismeret');
  if CheckResult then Exit;

  SearchList(CBC_DeadLanguageStrings, 'Holt nyelv');
  if CheckResult then Exit;

  SearchList(CBC_ReligionStrings, 'Vallásismeret');
  if CheckResult then Exit;

  SearchList(CBC_RaceStrings, 'Faj');
  if CheckResult then Exit;

  Result := False;
end;

procedure TCustomCharacter.SetClass(AClassIndex: Integer);
var DmgStat: TStat;
    ManaStat: TStat;
    ModPos, TempInt: Integer;
begin
// Check if the update is necessary
  if GetStat('Kaszt').FBaseValue = AClassIndex then Exit;

  DmgStat := GetStat('Sebzésjárulék');

  if AClassIndex = 2 then
    DmgStat.FModifiers.AddObject(0, GetStat('Szint'))
  else
    if GetModifier(DmgStat, 'Szint', ModPos) <> nil then
      DmgStat.FModifiers.Delete(ModPos);

  case AClassIndex of
    5..7, 10..13:
      if (GetStat('Mana') = nil) and (GetStat('Mana / Szint') = nil) then
        begin
          AddStat(['Mana','Mana / Szint']);

          SetupConnections(GetStat('Mana'));
          SetupConnections(GetStat('Mana / Szint'));
        end;
  else
    if (GetStat('Mana') <> nil) and (GetStat('Mana / Szint') <> nil) then
      RemoveStat(['Mana / Szint','Mana']);
  end;

  ManaStat := GetStat('Mana / Szint');

  case AClassIndex of
    5:  begin   // Bárd
          TempInt := GetStat('Intelligencia').FCurrentValue - STATBONUSTHRESHOLD;
          if Tempint < 0 then
            TempInt := 0;

          ManaStat.BaseValue := TempInt;
        end;
    6, 7: begin // Pap, Paplovag
            ManaStat.BaseValue := 9;
          end;
    10: begin   // Boszorkány
          ManaStat.BaseValue := 8;
        end;
    11: begin   // Boszorkánymester
          ManaStat.BaseValue := 7;
        end;
    12: begin   // Tûzvarázsló
          ManaStat.BaseValue := 6;
        end;
    13: begin   // Varázsló
          ManaStat.BaseValue := 10;
        end;
  end;

  GetStat('Kaszt').BaseValue := AClassIndex;
end;
//    ('Harcos','Gladiátor','Fejvadász','Lovag','Tolvaj',                         // 0 .. 4
//     'Bárd','Pap','Paplovag','Harcmûvész','Kardmûvész',                         // 5 .. 9
//     'Boszorkány','Boszorkánymester','Tûzvarázsló','Varázsló');                 // 10 .. 13

//     'Szint','Mana','Mana / Szint','Sebzésjárulék','Pszi','AME','MME',          // 20 .. 26
//     'Nem','Jellem','Faj','Kaszt','Szülõföld','Vallás','Életkor');              // 27 .. 33

procedure TCustomCharacter.SetRace(ARaceIndex: Integer);
var SearchIndex, ModIndex: Integer;

  procedure SetRacialMod(const AName: String; const ANewValue: Integer);
  var ModStat: TStat;
      Cv1: Integer;
  begin
    ModStat := GetStat(AName);
    if ModStat <> nil then
      for Cv1 := 0 to ModStat.FModifiers.Count - 1 do
        if TStat(ModStat.FModifiers.Objects[Cv1]).FName = 'Faj' then
          ModStat.FModifiers[Cv1] := ANewValue;

    ModStat.Modified := True;
  end;

begin
// Check if the update is necessary
  if GetStat('Faj').FBaseValue = ARaceIndex then Exit;

// Remove previous bonuses
  for SearchIndex := 0 to GetStat('Érzékelés').FBaseListPos do // No need to check the rest of the list
    for ModIndex := 0 to FStats[SearchIndex].FModifiers.Count - 1 do
      if TStat(FStats[SearchIndex].FModifiers.Objects[ModIndex]).FName = 'Faj' then
        begin
          FStats[SearchIndex].FModifiers[ModIndex] := 0;
          FStats[SearchIndex].Modified := True;
        end;

  case ARaceIndex of
// Ember
// Elf
    1:  begin
          SetRacialMod('Erõ', -2);
          SetRacialMod('Gyorsaság', 1);
          SetRacialMod('Ügyesség', 1);
          SetRacialMod('Állóképesség', -1);
          SetRacialMod('Szépség', 1);
        end;
// Félelf
    2:  begin
          SetRacialMod('Erõ', -1);
          SetRacialMod('Gyorsaság', 1);
        end;
// Törpe
    3:  begin
          SetRacialMod('Erõ', 1);
          SetRacialMod('Állóképesség', 1);
          SetRacialMod('Egészség', 1);
          SetRacialMod('Szépség', -2);
          SetRacialMod('Intelligencia', -1);
          SetRacialMod('Asztrál', -2);
        end;
// Udvari Ork
    4:  begin
          SetRacialMod('Erõ', 2);
          SetRacialMod('Állóképesség', 1);
          SetRacialMod('Egészség', 2);
          SetRacialMod('Szépség', -3);
          SetRacialMod('Intelligencia', -1);
          SetRacialMod('Asztrál', -3);
        end;
// Goblin
    5:  begin
          SetRacialMod('Erõ', -2);
          SetRacialMod('Gyorsaság', 2);
          SetRacialMod('Szépség', -3);
          SetRacialMod('Érzékelés', 2);
        end;
// Gnóm
    6:  begin
          SetRacialMod('Erõ', -1);
          SetRacialMod('Ügyesség', 2);
          SetRacialMod('Egészség', 1);
          SetRacialMod('Szépség', -3);
          SetRacialMod('Érzékelés', 2);
        end;
  end;

  GetStat('Faj').BaseValue := ARaceIndex;
end;

function TCustomCharacter.SetStat(AStat: TStat; NewBaseValue: Integer): Boolean;
begin
  DebugManager.EventList.Add('Trying to modify a base value on <' + AStat.FName + '> to a value of (' + IntToStr(NewBaseValue) + ')');

  Result := False;

  if (NewBaseValue >= GetStatRange(AStat.FShortName, stMIN)) and
     (NewBaseValue <= GetStatRange(AStat.FShortName, stMAX)) and
     (GetRemainingKAP + AStat.GetKAP - AStat.GetKAP(NewBaseValue) >= 0) then
    begin
      AStat.BaseValue := NewBaseValue;
      Result := True;
    end;

end;

////////////////////////////////////////////////////////////////////////////////
////////////////////////////    LOADING ROUTINES    ////////////////////////////
////////////////////////////////////////////////////////////////////////////////
{$message Hint 'LoadSkills(FileName: String)'}
procedure LoadSkills(const FileName: String = SkillDataFileName);
var DataFile: TextFile;
    TempStr, SubStr: String;
    MainCycleVar, LoopVar, NodePosInList: Integer;
    SkillPosInList, LevelPosInList, ReqPosInList: Integer;
    SortList: TStrings;
begin
  if not FileExists(FileName) then
    begin
      Exit;
    end;

  SortList := TStringList.Create;

  try
    AssignFile(DataFile, FileName);
    Reset(DataFile);
    while not Eof(DataFile) do
      begin
        ReadLn(DataFile, TempStr);
// Ignore emptly lines
        if TempStr <> '' then
// Only read the non-comment lines
          if AnsiPos('//', TempStr) = 0 then
            SortList.Append(TempStr)
          else
            SkillCommentLines.Add(TempStr);
      end;

    SkillPosInList := 0;
    for MainCycleVar := 0 to SortList.Count - 1 do
      begin
// If the line contains a Node reference (#)
        if Pos('#', SortList[MainCycleVar]) <> 0 then
          begin
            TempStr := Copy(SortList[MainCycleVar], Pos('{', SortList[MainCycleVar]) + 1,
              Pos('}', SortList[MainCycleVar]) - Pos('{', SortList[MainCycleVar]) - 1);

            NodePosInList := NodeData.Add(TempStr);

// If the line contains a Subnode reference (-)
            if Pos('-', SortList[MainCycleVar]) <> 0 then
              NodeData.Objects[NodePosInList] := SecondaryNodeMarker
            else
              NodeData.Objects[NodePosInList] := PrimaryNodeMarker;

          end
        else
          if Pos('=', SortList[MainCycleVar]) = 0 then
            begin
              SkillPosInList := Length(BaseSkillData);
              SetLength(BaseSkillData, SkillPosInList + 1);

              BaseSkillData[SkillPosInList].Name := Copy(SortList[MainCycleVar],
                Pos('{', SortList[MainCycleVar]) + 1,
                Pos('}', SortList[MainCycleVar]) - Pos('{', SortList[MainCycleVar]) - 1);

              BaseSkillData[SkillPosInList].IsPercentSkill := Pos('%', SortList[MainCycleVar]) <> 0;

              NodeData.Add(BaseSkillData[SkillPosInList].Name);

//The first temporary entry is the SubType Reference
              if Pos('!', SortList[MainCycleVar]) <> 0 then
                begin
                  TempStr:= SortList[MainCycleVar];
                  Delete(TempStr, 1, Pos('!', TempStr));

                  if TempStr <> '' then
                    BaseSkillData[SkillPosInList].SubTypeRefSkill := TempStr
                  else
                    BaseSkillData[SkillPosInList].SubTypeRefSkill := BaseSkillData[SkillPosInList].Name;
                end;

            end
          else
            begin
              LevelPosInList := Length(BaseSkillData[SkillPosInList].Levels);
              SetLength(BaseSkillData[SkillPosInList].Levels, LevelPosInList + 1);

              TempStr:= SortList[MainCycleVar];
// Get the level (this is importat in the case of a percentskill where levels are different than 1..5)
//              BaseSkillData[SkillPosInList].Levels[LevelPosInList].ValidFromLevel := StrToInt(Copy(TempStr, 2, 2));

              if IsDelimiter('[<!(', TempStr, 4) then // Number of digits (Ex.:  =01[ - 2 digits in the middle of 4)
                BaseSkillData[SkillPosInList].Levels[LevelPosInList].ValidFromLevel := StrToInt(Copy(TempStr, 2, 2))
              else
                BaseSkillData[SkillPosInList].Levels[LevelPosInList].ValidFromLevel := StrToInt(Copy(TempStr, 2, 3));

// Delete the first few characters only used to ID the line
              Delete(TempStr, 1, Pos('[', TempStr) - 1);

// Read data between every brackets of [ ] and position them in their correct place
              while Pos('[', TempStr) > 0 do
                begin
// Add a Requirement record
                  ReqPosInList := Length(BaseSkillData[SkillPosInList].Levels[LevelPosInList].Requirements);
                  SetLength(BaseSkillData[SkillPosInList].Levels[LevelPosInList].Requirements, ReqPosInList + 1);

                  SubStr:= Copy(TempStr, Pos('[', TempStr) + 1, Pos('|', TempStr) - Pos('[', TempStr) - 1);

// Search for a Primary Stat and reset SubStr to indicate a find
                  for LoopVar := USER_STAT_LOW to USER_STAT_HIGH do
                    if SubStr = ComponentNames[LoopVar] then
                      begin
                        BaseSkillData[SkillPosInList].Levels[LevelPosInList].Requirements[ReqPosInList].ReqName := ComponentNames[LoopVar];
                        BaseSkillData[SkillPosInList].Levels[LevelPosInList].Requirements[ReqPosInList].IsStat := True;
                        SubStr := '';
                        Break;
                      end;

// If the data indicates a skill
                  if SubStr <> '' then
                    begin
                      BaseSkillData[SkillPosInList].Levels[LevelPosInList].Requirements[ReqPosInList].ReqName := SubStr;
                      BaseSkillData[SkillPosInList].Levels[LevelPosInList].Requirements[ReqPosInList].IsStat := False;
                      SubStr := '';
                    end;

// Finally, get the value
                  SubStr:= Copy(TempStr, Pos('|', TempStr) + 1, Pos(']', TempStr) - Pos('|', TempStr) - 1);
                  BaseSkillData[SkillPosInList].Levels[LevelPosInList].Requirements[ReqPosInList].ReqValue := StrToInt(SubStr);

// Delete the analyzed part of the string
                  Delete(TempStr, 1, Pos(']', TempStr));
                end;

              if Pos('<', TempStr) > 0 then
                begin
                  SubStr:= Copy(TempStr, Pos('<', TempStr) + 1, Pos('>', TempStr) - Pos('<', TempStr) - 1);
                  BaseSkillData[SkillPosInList].Levels[LevelPosInList].Price := StrToInt(SubStr);
                  Delete(TempStr, 1, Pos('>', TempStr));
                end;

            end;
      end;
  finally
    CloseFile(DataFile);
    SortList.Free;
  end;
end;

{$message Hint 'LoadWeapons(FileName: String)'}
procedure LoadWeapons(const FileName: String = WeaponDataFileName);
var DataFile: TextFile;
    TempStr, SubStr: String;
    MainCycleVar, LoopVar, WeaponPosInList: Integer;
    SortList: TStrings;
begin
  if not FileExists(FileName) then
    begin
      Exit;
    end;

  SortList := TStringList.Create;

  try
    AssignFile(DataFile,FileName);
    Reset(DataFile);
    while not Eof(DataFile) do
      begin
        ReadLn(DataFile, TempStr);
// Ignore emptly lines
        if TempStr <> '' then
// Only read the non-comment lines
          if AnsiPos('//', TempStr) = 0 then
            SortList.Append(TempStr)
          else
            WeaponCommentLines.Add(TempStr);
      end;

    WeaponPosInList := 0;
    for MainCycleVar := 0 to SortList.Count - 1 do
      begin
        WeaponPosInList := Length(BaseWeaponData);
        SetLength(BaseWeaponData, WeaponPosInList + 1);

        TempStr := SortList[MainCycleVar];

        SubStr := Copy(TempStr, Pos('{', TempStr) + 1, Pos('}', TempStr) - Pos('{', TempStr) - 1);
        with BaseWeaponData[WeaponPosInList] do
          begin
            Name := SubStr;

            Delete(TempStr, 1, Pos('(', TempStr));
// LoopVar shows which part of the line we're investigating for relevant data
            for LoopVar := 0 to WEAPONDATALENGTH do
              begin
                SubStr := Copy(TempStr, 1, Pos(',', TempStr) - 1);
                case LoopVar of
                   0: Category := TWeaponCategory(StrToInt(SubStr));
                   1: Stat_KE := StrToInt(SubStr);
                   2: Stat_TE := StrToInt(SubStr);
                   3: Stat_VE := StrToInt(SubStr);
                   4: Stat_CE := StrToInt(SubStr);
                   5: Stat_Tav := StrToInt(SubStr);
                   6: Stat_MGT := StrToInt(SubStr);
                   7: Dmg_Min := StrToInt(SubStr);
                   8: Dmg_Max := StrToInt(SubStr);
                   9: Dmg_Add := StrToInt(SubStr);
                  10: TPK := StrToInt(SubStr);
                  11: ReqType := SubStr;
                  12: ReqValue := StrToInt(SubStr);
                  13: DoubleHanded := Copy(TempStr, 1, Pos(')', TempStr) - 1) = '1';
                end;

                Delete(TempStr, 1, Pos(',', TempStr));
              end;

          end;
      end;
  finally
    CloseFile(DataFile);
    SortList.Free;
  end;
end;

{$message Hint 'LoadArmor(FileName: String)'}
procedure LoadArmor(const FileName: String = ArmorDataFileName);
var DataFile: TextFile;
    TempStr, SubStr: String;
    MainCycleVar, LoopVar, ArmorPosInList: Integer;
    SortList: TStrings;
begin
  if not FileExists(FileName) then
    begin
      Exit;
    end;

  SortList := TStringList.Create;

  try
    AssignFile(DataFile,FileName);
    Reset(DataFile);
    while not Eof(DataFile) do
      begin
        ReadLn(DataFile, TempStr);
// Ignore emptly lines
        if TempStr <> '' then
// Only read the non-comment lines
          if AnsiPos('//', TempStr) = 0 then
            SortList.Append(TempStr)
          else
            ArmorCommentLines.Add(TempStr);
      end;

    ArmorPosInList := 0;
    for MainCycleVar := 0 to SortList.Count - 1 do
      begin
        ArmorPosInList := Length(BaseArmorData);
        SetLength(BaseArmorData, ArmorPosInList + 1);

        TempStr := SortList[MainCycleVar];

        SubStr := Copy(TempStr, Pos('{', TempStr) + 1, Pos('}', TempStr) - Pos('{', TempStr) - 1);

        with BaseArmorData[ArmorPosInList] do
          begin
            Name := SubStr;

            Delete(TempStr, 1, Pos('(', TempStr));

// LoopVar shows which part of the line we're investigating for relevant data
            for LoopVar := 0 to ARMORDATALENGTH do
              begin
                SubStr := Copy(TempStr, 1, Pos(',', TempStr) - 1);
                case LoopVar of
                   0: Stat_SFE := StrToInt(SubStr);
                   1: Stat_MGT := StrToInt(SubStr);
                   2: begin
                        SubStr := Copy(TempStr, 1, Pos(')', TempStr) - 1);
                        if SubStr = 'Helmet' then
                          Category := acHelmet;
                        if SubStr = 'Vest' then
                          Category := acVest;
                        if SubStr = 'Greaves' then
                          Category := acGreaves;
                        if SubStr = 'Gauntlets' then
                          Category := acGauntlets;
                        if SubStr = 'Boots' then
                          Category := acBoots;
                      end;
                end;

                Delete(TempStr, 1, Pos(',', TempStr));
              end;
          end;
      end;
  finally
    CloseFile(DataFile);
    SortList.Free;
  end;
end;

{$message Hint 'LoadEquipment(FileName: String)'}
procedure LoadEquipment(const FileName: String = EquipmentDataFileName);
var DataFile: TextFile;
    TempStr, SubStr: String;
    MainCycleVar, LoopVar, EquipmentPosInList, TempInt: Integer;
    SortList: TStrings;
    ReadingData: Boolean;
begin
  if not FileExists(FileName) then
    begin
      Exit;
    end;

  SortList := TStringList.Create;
  ReadingData := True;
  Randomize;

  try
    AssignFile(DataFile,FileName);
    Reset(DataFile);
    while not Eof(DataFile) do
      begin
        ReadLn(DataFile, TempStr);
// Ignore emptly lines
        if TempStr <> '' then
// Only read the non-comment lines
          if AnsiPos('//', TempStr) = 0 then
            SortList.Append(TempStr)
          else
            EquipmentCommentLines.Add(TempStr);
      end;

    EquipmentPosInList := 0;

    for MainCycleVar := 0 to SortList.Count - 1 do
      begin
        EquipmentPosInList := Length(BaseEquipmentData);
        SetLength(BaseEquipmentData, EquipmentPosInList + 1);

        TempStr := SortList[MainCycleVar];

        SubStr := Copy(TempStr, Pos('{', TempStr) + 1, Pos('}', TempStr) - Pos('{', TempStr) - 1);
        BaseEquipmentData[EquipmentPosInList].Name := SubStr;

        Delete(TempStr, 1, Pos('}', TempStr));

//	EQ : általános felszerelés, olyan dolgok, amikbõl általában egy van egy karakternél. (pl. kulacs, tûzszerszám)
//	PA : Zsákok, tárolóeszközök
// 	MA : varázstárgyak (pl. hatalom amulettje, gyûrûk. rúnázási szintek)
//	CO : fogyóeszközök. (pl. az élelmiszerek, kötszerek, fáklya)
//	PO : mérgek
//	MP : varázsitalok (pl. gyógyital, sebezhetetlenség itala)
        BaseEquipmentData[EquipmentPosInList].Category := ecGeneral; // Default (Also for 'EQ')

        SubStr := TempStr[1] + TempStr[2];
        if SubStr = 'PA' then
          BaseEquipmentData[EquipmentPosInList].Category := ecContainer;
        if SubStr = 'MA' then
          BaseEquipmentData[EquipmentPosInList].Category := ecMagicItem;
        if SubStr = 'CO' then
          BaseEquipmentData[EquipmentPosInList].Category := ecConsumable;
        if SubStr = 'PO' then
          BaseEquipmentData[EquipmentPosInList].Category := ecPoison;
        if SubStr = 'MP' then
          BaseEquipmentData[EquipmentPosInList].Category := ecPotion;
        Delete(TempStr, 1, 2);

        TempInt := LastDelimiter(']', TempStr);
        SubStr := Copy(TempStr, 1, TempInt);
        if SubStr <> '' then
          BaseEquipmentData[EquipmentPosInList].Specials := SubStr;
        Delete(TempStr, 1, TempInt);

        SubStr := Copy(TempStr, Pos('<', TempStr) + 1, Pos('>', TempStr) - Pos('<', TempStr) - 1);
        if SubStr <> '' then
          BaseEquipmentData[EquipmentPosInList].CopperPrice := StrToInt(SubStr);
      end;
  finally
    CloseFile(DataFile);
    SortList.Free;
  end;
end;

initialization
  PrimaryNodeMarker := TObject.Create;
  SecondaryNodeMarker := TObject.Create;
  RequirementIsMetMarker := TObject.Create;
  NodeData := TStringList.Create;

// Create lists for comments
  SkillCommentLines := TStringList.Create;
  WeaponCommentLines := TStringList.Create;
  ArmorCommentLines := TStringList.Create;
  EquipmentCommentLines := TStringList.Create;

// Load data to lists from files
  LoadSkills(SkillDataFileName);
  LoadWeapons(WeaponDataFileName);
  LoadArmor(ArmorDataFileName);
  LoadEquipment(EquipmentDataFileName);

finalization
  PrimaryNodeMarker.Free;
  SecondaryNodeMarker.Free;
  RequirementIsMetMarker.Free;
  NodeData.Free;

// Free the commentlists
  SkillCommentLines.Free;
  WeaponCommentLines.Free;
  ArmorCommentLines.Free;
  EquipmentCommentLines.Free;
end.

(*
procedure TMainForm.SaveBook(SaveAs: Boolean);
var DataFile: TFileStream;
    Cv1, Cv2: Integer;
    TempInt: Word;
    TempStr: ShortString;
    DataType: Cardinal;
begin
  if (SaveAs) or (CurrentFile = '') then
    if not PromptForFileName(CurrentFile,'Könyvek (*.kjk)|*.kjk','.kjk',
         'Válaszd ki az elmentendõ file nevét!', BookDir, True) then
        Exit;

  try
    DataFile:= TFileStream.Create(CurrentFile, fmCreate);
    for Cv1:= 0 to Length(Book) - 1 do
      begin
        DataType := fidNewPage;
        Datafile.Write(DataType, SizeOf(fidNewPage));

        DataType := fidNumber;
        Datafile.Write(DataType, SizeOf(fidNumber));
        Datafile.Write(Book[Cv1].Number, SizeOf(Book[Cv1].Number));

        DataType := fidLink;
        Datafile.Write(DataType, SizeOf(fidLink));
        Datafile.Write(Book[Cv1].LinkTo, SizeOf(Book[Cv1].LinkTo));

        DataType := fidLocName;
        Datafile.Write(DataType, SizeOf(fidLocName));
        Datafile.Write(Book[Cv1].LocName, SizeOf(Book[Cv1].LocName));

        DataType := fidPicName;
        Datafile.Write(DataType, SizeOf(fidPicName));
        Datafile.Write(Book[Cv1].PicName, SizeOf(Book[Cv1].PicName));

        DataType := fidPicPos;
        Datafile.Write(DataType, SizeOf(fidPicPos));
        Datafile.Write(Book[Cv1].PicPos, SizeOf(Book[Cv1].PicPos));

        DataType := fidText;
        Datafile.Write(DataType, SizeOf(fidText));
        TempInt := Book[Cv1].Text.Count;
        Datafile.Write(TempInt, SizeOf(TempInt));
        if TempInt -1 > -1 then
          for Cv2:= 0 to TempInt - 1 do
            begin
              TempStr := Book[Cv1].Text[Cv2];
              Datafile.Write(TempStr, SizeOf(TempStr));
            end;
      end;
    Saved := True;
  finally
    FreeAndNil(DataFile);
  end;
  UpdateStatusBar;
end;

procedure TMainForm.LoadBookButtonClick(Sender: TObject);
var DataFile: TFileStream;
    TempInt, Cv1: Word;
    TempStr: ShortString;
    DataType: Cardinal;
begin
  if not Saved then
    if not ((Length(Book) = 1) and (PageTextMemo.Lines.Count = 0)) then
      if MessageDlg('A lista nincs mentve! Szeretnél most menteni?', mtConfirmation, [mbYes, mbNo], 0) = mrYes then
        SaveBookButtonClick(Self);

  if not PromptForFileName(CurrentFile,'Könyvek (*.kjk)|*.kjk','.kjk',
           'Válaszd ki a betöltendõ file nevét!', BookDir, False) then
    Exit;

  try
    SetLength(Book, 0);
    DataFile:= TFileStream.Create(CurrentFile, fmOpenRead);
    repeat
      if Datafile.Read(DataType, SizeOf(DataType)) > 0 then
        begin
          if DataType = fidNewPage then
           begin
             SetLength(Book, Length(Book) + 1);
             Book[Length(Book) - 1].Text := TStringList.Create;
           end;
          if DataType = fidNumber then
            Datafile.Read(Book[Length(Book) - 1].Number, SizeOf(Book[Length(Book) - 1].Number));
          if DataType = fidLink then
            Datafile.Read(Book[Length(Book) - 1].LinkTo, SizeOf(Book[Length(Book) - 1].LinkTo));
          if DataType = fidLocName then
            Datafile.Read(Book[Length(Book) - 1].LocName, SizeOf(Book[Length(Book) - 1].LocName));
          if DataType = fidPicName then
            Datafile.Read(Book[Length(Book) - 1].PicName, SizeOf(Book[Length(Book) - 1].PicName));
          if DataType = fidPicPos then
            Datafile.Read(Book[Length(Book) - 1].PicPos, SizeOf(Book[Length(Book) - 1].PicPos));
          if DataType = fidText then
            begin
              Datafile.Read(TempInt, SizeOf(TempInt));
              if TempInt > 0 then
                for Cv1:= 0 to TempInt - 1 do
                  begin
                    Datafile.Read(TempStr, SizeOf(TempStr));
                    Book[Length(Book) - 1].Text.Append(TempStr);
                  end;
            end;
        end;
    until DataFile.Size = DataFile.Position;
  finally
    FreeAndNil(DataFile);
  end;
  PageNumUpDown.Max := Length(Book);
  PageNumUpDown.Position := PageNumUpDown.Min;
  PageNumUpDown.Invalidate;
  Saved := True;
  PageRefresh;
end;



procedure TCustomCharacter.EquipItem(AEquipment: TEquipment; const NewLocation: TEquipmentLocation);
var Equipped: TEquipment;
begin
  Equipped := GetEquipmentAtLocation(NewLocation);

  if Equipped = AEquipment then Exit;

  if Equipped <> nil then
    begin
      DebugManager.EventList.Add('Removing an equipped <' + Equipped.FName + '>');

      Equipped.FLocation := elBackPack;

      if (NewLocation = elRightHand) and (AEquipment is TCustomWeapon) and (TCustomWeapon(AEquipment).DoubleHanded) then
        begin
          Equipped := GetEquipmentAtLocation(elLeftHand);

          if Equipped <> nil then
            begin
              Equipped.FLocation := elBackPack;
              DebugManager.EventList.Add('Equipment is doublehanded. Removing an equipped shield <' + Equipped.FName + '>');
            end;
        end;

      if (NewLocation = elLeftHand) and (Equipped is TCustomWeapon) and (TCustomWeapon(Equipped).DoubleHanded) then
        begin
          Equipped.FLocation := elBackPack;

          DebugManager.EventList.Add('Equipment is a shield. Removing an equipped doublehanded weapon <' + Equipped.FName + '>');
        end;
    end;

  AEquipment.FLocation := NewLocation;

  DebugManager.EventList.Add('Equipped a <' + AEquipment.FName + '>');
end;
  *)
