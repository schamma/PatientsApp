import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MembersService } from '../../_services/members.service';
import { Member } from '../../_models/member';
import { NgxGalleryOptions, NgxGalleryImage, NgxGalleryAnimation } from '@kolkov/ngx-gallery';
import { AllergyChecks } from '../../_models/allergyChecks';

@Component({
  selector: 'app-member-detail',
  standalone: false,
  
  templateUrl: './member-detail.component.html',
  styleUrl: './member-detail.component.css'
})
export class MemberDetailComponent implements OnInit {
  member: Member | undefined;
  allergyChecks: AllergyChecks;
  galleryOptions: NgxGalleryOptions[];
  galleryImages: NgxGalleryImage[];
  imageSrc = './assets/user.png'  

  constructor(private memberService: MembersService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadMember(); 
  }

  loadMember() {
    this.memberService.getMember(this.route.snapshot.paramMap.get('username')!).subscribe(member => {
      this.member = member
    })
  }
}
