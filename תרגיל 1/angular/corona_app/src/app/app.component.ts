import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MemberListComponent } from '../member-list/member-list.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [MemberListComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'corona_app';
}
