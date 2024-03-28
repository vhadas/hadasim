import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { Member } from '../../member.model';

@Component({
  selector: 'app-add-member',
  standalone: true,
  imports: [CommonModule,ReactiveFormsModule],
  templateUrl: './add-member.component.html',
  styleUrl: './add-member.component.scss'
})
export class AddMemberComponent {
  @Output()
  public onAddMemberEvent: EventEmitter<Member> = new EventEmitter<Member>();

  public addMemberForm: FormGroup = new FormGroup({
    "company": new FormControl(),
    "model": new FormControl(),
    "year": new FormControl()
  })


}
