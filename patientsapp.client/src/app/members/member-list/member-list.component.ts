import { Component, OnInit } from '@angular/core';
import { Member } from '../../_models/member';
import { MembersService } from '../../_services/members.service';
import { Observable, take } from 'rxjs';
import { Pagination } from '../../_models/pagination';
import { AccountService } from '../../_services/account.service';
import { User } from '../../_models/user';
import { UserParams } from '../../_models/userParams';

@Component({
  selector: 'app-member-list',
  standalone: false,
  
  templateUrl: './member-list.component.html',
  styleUrl: './member-list.component.css'
})
export class MemberListComponent implements OnInit {
  members: Member[];
  memberPartial: Partial<Member[]>;
  pagination: Pagination;
  userParams: UserParams;
  user: User;
  genderList = [{ value: 'male', display: 'Males' }, { value: 'female', display: 'Females' }];

  constructor(private memberService: MembersService, private accountService: AccountService) {
    this.accountService.currentUser$.pipe(take(1)).subscribe(user => {
      this.user = user;
      this.userParams = new UserParams(user);
    })
  }

  ngOnInit(): void {
    this.loadMembers();
  }

  loadMembers() {
    this.memberService.getMembers(this.userParams).subscribe(response => {
      this.members = response.result;
      this.pagination = response.pagination;
    })
  }

  resetFilters() {
    this.userParams = new UserParams(this.user);
    this.loadMembers();
  }

  pageChanged(event: any) {
    this.userParams.pageNumber = event.page;
    this.loadMembers();
  }
}
