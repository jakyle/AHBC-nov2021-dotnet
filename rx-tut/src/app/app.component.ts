import { Component, ElementRef, OnDestroy,  ResolvedReflectiveFactory, ViewChild, AfterViewInit  } from '@angular/core';
import { FormControl } from '@angular/forms';
import { filter, fromEvent, map, mergeMap, Observable, of, Subscription } from 'rxjs';
import { DogApiService } from './dog-api.service';
import { StarwarsApiService } from './starwars-api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnDestroy, AfterViewInit {

  constructor(private _dogService: DogApiService, private _starWarsService: StarwarsApiService) { 
    this.numberFormControl = new FormControl();

    this.numbers$ = this.numberFormControl.valueChanges.pipe(
      map(x => x*2)
    );


    this.dogImg$ = this.numbers$.pipe(
      filter(x => x > 5),
      mergeMap(_ => this._dogService.getRandomDog()),
      map(dogResponse => dogResponse.message)
    );

    this.starWarsName$ = this.numbers$.pipe(
      filter(x => x <= 5),
      mergeMap(x => this._starWarsService.getPerson(x)),
      map(starWarsResponse => starWarsResponse.name)
    );

    this.nameSubscription = this.starWarsName$.subscribe(name => alert(name));
    
  }


  // this view child is "decorating" the getDogButton element which captures a reference to the html element
  @ViewChild('button') 
  getDogButton!: ElementRef<HTMLButtonElement>;

  clicks$!: Observable<any>;

  title = 'rx-tut';

  numbers$: Observable<number>;
  dogImg$: Observable<string>;
  starWarsName$: Observable<string>;
  dogImageClick$!: Observable<string>;
  nameSubscription: Subscription;

  numberFormControl: FormControl;


  ngAfterViewInit(): void {
    this.clicks$ = fromEvent(this.getDogButton.nativeElement, 'click');

    this.dogImageClick$ = this.clicks$.pipe(
      mergeMap(_ => this._dogService.getRandomDog()),
      map(dogResponse => dogResponse.message)
    );
  }

  ngOnDestroy(): void {
    this.nameSubscription.unsubscribe();
  }

}
