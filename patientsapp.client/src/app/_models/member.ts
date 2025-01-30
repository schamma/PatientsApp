//import { Photo } from './reccomendations';
//import { Reccomendations } from './reccomendations';
import { AllergyCheck } from './allergyCheck';
import { FollowUps } from './followUps';
import { Screenings } from './screenings';

export interface Member {
  id: number;
  username: string;
  firstName: string;
  lastName: string;
  //photoUrl: string;
  age: number;
  created: Date;
  dateOfBirth: Date;
  lastActive: Date;
  gender: string;
  //photos: Photo[];
  //reccomendations: Reccomendations[];
  allergyCheck: AllergyCheck[];
  screenings: Screenings[];
  followUps: FollowUps[];
}
