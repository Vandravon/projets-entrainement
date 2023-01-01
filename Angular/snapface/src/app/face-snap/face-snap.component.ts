import { Component, OnInit, Input } from '@angular/core';
import { FaceSnap } from '../models/face-snap.model';

@Component({
  selector: 'app-face-snap',
  templateUrl: './face-snap.component.html',
  styleUrls: ['./face-snap.component.scss'],
})
export class FaceSnapComponent implements OnInit {
  @Input() faceSnap!: FaceSnap;

  title!: string;
  description!: string;
  createdDate!: Date;
  snaps!: number;
  imageUrl!: string;
  snapped!: boolean;
  buttonText!: string;

  ngOnInit() {
    this.snapped = false;
    this.buttonText = 'Oh Snap!';
  }

  onClickSnap() {
    if (this.snapped) {
      this.faceSnap.snaps--;
      this.snapped = false;
      this.buttonText = 'Oh Snap!';
    } else {
      this.faceSnap.snaps++;
      this.snapped = true;
      this.buttonText = 'Unsnap!!';
    }
  }
}
