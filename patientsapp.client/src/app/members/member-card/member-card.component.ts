import { Component, OnInit, Input } from '@angular/core';
import { Member } from '../../_models/member';

@Component({
  selector: 'app-member-card',
  standalone: false,
  
  templateUrl: './member-card.component.html',
  styleUrl: './member-card.component.css',
})
export class MemberCardComponent implements OnInit{
  @Input() member: Member | undefined;
  imageSrc = './assets/user.png'  

  constructor() { }

  ngOnInit(): void {

  }
}
