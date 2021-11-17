
//export class ActivityUpdate{
//  IdActivityUpdate: number;
//  WeeklyColumn: string;
//  Calendar: string;
//  DailyActivity: string;
//  LostSabbath: string;
//  ClassId: number;
//  TeacherId: number;
//  Class: Classes;
//  Teacher: TeacherAndManager;

//}

//export class Classes {
//  ClassId: number;
//  KindOfClassId: number;
//  ActivityUpdate: ICollection<ActivityUpdate>;
//  Kids: ICollection<Kids>;
//  PlacementOfATeacher: ICollection<PlacementOfATeacher>;
//  TypeClass: ICollection<TypeClass>;
//}


//export class DayCare {
//  IdDayCare: number;
//  NameDayCare: string;
//  NumClasses: number;
//  DressDayCare: string;
//  AboutDayCare: string;
//}


//export class Kids {
//  TzKids: number;
//  NameKids: string;
//  AgeKids: string;
//  ClassId: number;
//  DateBorn: Date;
//  ParentsId: number;
//  AttendanceId: number;
//  Attendance: KidsAttendance;
//  Class: Classes;
//  Parents: Parents;
//}


//export class KidsAttendance {
//  AttendanceId: number;
//  KidId: number;
//  ParentId: number;
//  CurrentDate:Date;
//  Check: boolean;
//  Kids: ICollection<Kids>;
//}


////export class newMaonContext {}

//export class Parents {
//  ParentsId: number;
//  ParentsTz: number;
//  PersonTz: number;
//  PersonTzNavigation: Person;
//  kids: ICollection<Kids>;

//}


//export class Person {
//  PersonTz: number;
//  PersonName: string;
//  Adress: string;
//  Email: string;
//  PhoneNamber1: string;
//  PhoneNamber2: string;
//  Parents: ICollection<Parents>;
//  TeacherAndManager: ICollection<TeacherAndManager>;

//}


//export class PlacementOfATeacher {
//  IdPlacementOfATeacher: number;
//  Shifts: string;
//  DateShifts: Date;
//  ClassId: number;
//  TeacherId: number;
//  Class: Classes;
//  Teacher: TeacherAndManager;

//}


//export class TeacherAndManager {
//  TeacherId: number;
//  TeacherTz: number;
//  PersonTz: number;
//  PersonTzNavigation: Person;
//  ActivityUpdate: ICollection<ActivityUpdate>;
//  PlacementOfATeacher: ICollection<PlacementOfATeacher>;
//  TypeEmployee: ICollection<TypeEmployee>;

//}


//export class TypeClass {
//  IdTypeClass: number;
//  TypeClassName: string;
//  ClassId: number;
//  Class: Classes;

//}


//export class TypeEmployee {
//  IdTypeEmp: number;
//  TypeEmpName: string;
//  TeacherId: number;
//  Teacher: TeacherAndManager;

//}

//להמשיך את כל המחלקות מהתיקיה models
