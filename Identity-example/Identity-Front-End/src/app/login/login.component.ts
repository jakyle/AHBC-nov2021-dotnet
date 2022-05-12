import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient, HttpParams } from '@angular/common/http';
import { map } from 'rxjs/internal/operators/map';
import { filter } from 'rxjs/internal/operators/filter';
import { switchMap } from 'rxjs/internal/operators/switchMap';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(
    private _activatedRoute: ActivatedRoute,
    private _authService: AuthService) { }

  onGithubLogin() {
    this._authService.redirectGitHubToken();
  }


  ngOnInit(): void {
    // localhost:4200/?code=12345&state=123435
    this._activatedRoute.queryParams.pipe(
      map(params => ({code: params["code"], state: params["state"]})),
      filter(p => p.code && p.state && p.state === localStorage.getItem("authState")),
      switchMap((p: {code: string}) => this._authService.getUser(p.code))
    ) 
    .subscribe(user => alert(user.login));
  }
  

}
