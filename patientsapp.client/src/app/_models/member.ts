import { AllergyChecks } from './allergyChecks';
import { FollowUps } from './followUps';
import { Screenings } from './screenings';

export interface Member {
  id: number;
  username: string;
  firstName: string;
  lastName: string;
  age: number;
  created: Date;
  dateOfBirth: Date;
  lastActive: Date;
  gender: string;
  allergyChecks: AllergyChecks[];
  screenings: Screenings[];
  followUps: FollowUps[];
}
