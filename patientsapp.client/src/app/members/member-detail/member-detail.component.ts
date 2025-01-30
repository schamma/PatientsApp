import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MembersService } from '../../_services/members.service';
import { Member } from '../../_models/member';
import { NgxGalleryOptions, NgxGalleryImage, NgxGalleryAnimation } from '@kolkov/ngx-gallery';
import { AllergyCheck } from '../../_models/allergyCheck';

@Component({
  selector: 'app-member-detail',
  standalone: false,
  
  templateUrl: './member-detail.component.html',
  styleUrl: './member-detail.component.css'
})
export class MemberDetailComponent implements OnInit {
  member: Member | undefined;
  //allergies: AllergyCheck[] = [];
  galleryOptions: NgxGalleryOptions[];
  galleryImages: NgxGalleryImage[];
  imageSrc = './assets/user.png'  

  constructor(private memberService: MembersService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadMember(); // go to api and load member 
    //this.loadAllergies();

    //this.galleryOptions = [
    //  {
    //    width: '500px',
    //    height: '500px',
    //    imagePercent: 100,
    //    thumbnailsColumns: 4,
    //    imageAnimation: NgxGalleryAnimation.Slide,
    //    preview: false
    //  }
    //]
  }

  //getImages(): NgxGalleryImage[] {
  //  const imageUrls = [];
  //  for (const photo of this.member.photos) {
  //    imageUrls.push({
  //      small: photo?.url,
  //      medium: photo?.url,
  //      big: photo?.url
  //    })
  //  }
  //  return imageUrls;
  //}

  //getReccomendations(): {
  //  const reccomendationArray = [];
  //  for (const reccomendation of this.member.reccomendations) {
  //    reccomendationArray.push({
  //      small: photo?.url,
  //      medium: photo?.url,
  //      big: photo?.url
  //    })
  //  }
  //  return reccomendationArray;
  //}

  loadMember() {
    this.memberService.getMember(this.route.snapshot.paramMap.get('username')!).subscribe(member => {
      this.member = member;
      //this.galleryImages = this.getImages();
    })
  }

  //loadAllergies() {
  //  throw new Error('Method not implemented.');
  //}
}
