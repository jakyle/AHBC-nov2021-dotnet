import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { v4 as uuidv4 } from 'uuid';
import { GithubUser } from './models/GithubUser';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private _http: HttpClient) { }

  baseUrl = "https://localhost:5001/auth";

  redirectGitHubToken() {
    const authState = uuidv4();
    localStorage.setItem("authState", authState);

    const queryParameters = [
      'client_id=3dfb91c04144d0908d3e',
      `state=${authState}`,
      'allow_signup=true',
      encodeURIComponent('redirect_uri=http://localhost:4200'),
    ];

    window.location.href = `https://github.com/login/oauth/authorize?${queryParameters.join('&')}`;
  }

  getUser(code: string) {
    return this._http.get<GithubUser>(`${this.baseUrl}/${code}`);
  }
}
