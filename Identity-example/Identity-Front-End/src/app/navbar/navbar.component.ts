import { Component, OnInit } from '@angular/core';
import { filter, switchMap } from 'rxjs';
import { AuthService } from '../auth.service';
import { User } from '../models/GithubUser';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  user$ = this._authService.user$;

  constructor(private _authService: AuthService,) { }

  user: User | null = null;

  ngOnInit(): void {
    const user = localStorage.getItem("user");
    if (user) {
      const currentUser = JSON.parse(user);

      this._authService.autoLogin(currentUser.id).subscribe(user => {
        if (user) {
          this._authService.setUser(user);
        }
      });
    }
  }

  logout() {
    localStorage.setItem("user", "");
    this._authService.user$.pipe(
      filter(user => user !== null),
      switchMap(user => this._authService.logout(user!.id))
    ).subscribe(_ => this._authService.setUser(null));
  }

}
