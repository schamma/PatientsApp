import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register',
  standalone: false,
  
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent implements OnInit{
  //@Input() usersFromHomeComponent: any;
  @Output() cancelRegister = new EventEmitter();
  model: any = {};

  //constructor() { }
  constructor(private accountService: AccountService, private toastr: ToastrService) { }

  ngOnInit(): void { }

  //register() {
  //  console.log(this.model);
  //}
  register() {
    this.accountService.register(this.model).subscribe(response => {
      console.log(response);
      this.cancel();
    }, error => {
      console.log(error);
      this.toastr.error(error.error);
    })
  }

  //cancel() {
  //  console.log('cancelled');
  //}
  cancel() {
    this.cancelRegister.emit(false);
  }
}
