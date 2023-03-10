import { Component, OnInit } from '@angular/core';
import { FaceSnap } from './models/face-snap.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  mySnap!: FaceSnap;
  mySecondSnap!: FaceSnap;
  myThirdSnap!: FaceSnap;
  ngOnInit(): void {
    this.mySnap = new FaceSnap(
      'Archibald',
      'Mon meilleur ami depuis tout petit !',
      'https://cdn.pixabay.com/photo/2015/05/31/16/03/teddy-bear-792273_1280.jpg',
      new Date(),
      0
    );
    this.mySecondSnap = new FaceSnap(
      'Jean-Michel',
      'Vassago !',
      'https://picsum.photos/200',
      new Date(),
      0
    );
    this.myThirdSnap = new FaceSnap(
      'Robert',
      'Lecamionneur!',
      'https://picsum.photos/200/300',
      new Date(),
      0
    );
  }
}
