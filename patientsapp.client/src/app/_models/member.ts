import { Photo } from './photo';

export interface Member {
  id: number;
  username: string;
  photoUrl: string;
  age: number;
  created: Date;
  lastActive: Date;
  gender: string;
  photos: Photo[];
}
