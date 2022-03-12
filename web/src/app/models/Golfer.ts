import { Course } from "./Course";
export class Golfer {
  public golferId: number;
  public firstName: string;
  public lastName: string;
  public emailAddress: string;
  public birthDate?: Date;
  public age: number;
  public nickname?: string;
  public mobilePhone?: string;
  public address1?: string;
  public address2?: string;
  public city?: string;
  public state?: string;
  public postalCode?: string;
  public homeCourseId?: number;
  public homeCourse?: Course;
  public isActive: boolean = true;
}
