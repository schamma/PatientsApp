import { ActivatedRouteSnapshot, CanActivate, CanActivateFn, GuardResult, MaybeAsync, RouterStateSnapshot, UrlTree } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { AccountService } from '../_services/account.service';
import { Injectable } from '@angular/core';
import { User } from '../_models/user';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})

export class AuthGuard implements CanActivate {
  constructor(private accountService: AccountService, private toastr: ToastrService) { }

  canActivate(): Observable<boolean> {
    return this.accountService.currentUser$.pipe(
      map(user => {
        if (user) { return true; }
        else {
          this.toastr.error('You shall not pass!')
          return false;
        }
      })
    )
  }
}

//login(model: any) {
//  return this.http.post<User>(this.baseUrl + 'account/login', model).pipe(
//    map((response: User) => {
//      const user = response;
//      if (user) {
//        localStorage.setItem('user', JSON.stringify(user));
//        this.currentUserSource.next(user);
//      }
//    })
//  )
//}
