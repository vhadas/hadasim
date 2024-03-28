import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { Member } from '../../member.model';

@Component({
  selector: 'app-member-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './member-details.component.html',
  styleUrl: './member-details.component.scss'
})
export class MemberDetailsComponent {
  @Input()
  public member !:Member

}
