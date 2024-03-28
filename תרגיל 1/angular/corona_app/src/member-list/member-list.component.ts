import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Member } from '../../member.model';

@Component({
  selector: 'app-member-list',
  standalone: true,
  imports: [CommonModule,FormsModule, MemberDetailsComponent, AddMemberComponent],
  templateUrl: './member-list.component.html',
  styleUrl: './member-list.component.scss'
})
export class MemberListComponent {
  public isShowAddMember = false
  public searchInput: string = ""
  public isShowDetails = false
  public selectedMember!: Member
  public memberList : Member[]=[
    {
      FullName : "hadas",
      Id :"1",
      FullAddress :"bb",
      BirthDate : new Date,
      Telephone : "03111",
      Phone : "05111",
      Date1 : new Date,
      Date2 : new Date,
      Date3 : new Date,
      Date4 : new Date,
      Maker1 : "moderna",
      Maker2 : "fizer",
      Maker3 : "fizer",
      Maker4 : "moderna",
      DateOfResult : new Date,
      DateOfRecovery : new Date
    },
    {
      FullName : "efrat",
      Id :"2",
      FullAddress :"pt",
      BirthDate : new Date,
      Telephone : "03222",
      Phone : "05222",
      Date1 : new Date,
      Date2 : new Date,
      Date3 : new Date,
      Date4 : new Date,
      Maker1 : "moderna",
      Maker2 : "fizer",
      Maker3 : "fizer",
      Maker4 : "moderna",
      DateOfResult : new Date,
      DateOfRecovery : new Date
    },
    {
      FullName : "shira",
      Id :"3",
      FullAddress :"jlm",
      BirthDate : new Date,
      Telephone : "03333",
      Phone : "05333",
      Date1 : new Date,
      Date2 : new Date,
      Date3 : new Date,
      Date4 : new Date,
      Maker1 : "moderna",
      Maker2 : "fizer",
      Maker3 : "fizer",
      Maker4 : "moderna",
      DateOfResult : new Date,
      DateOfRecovery : new Date
    }
  ]
  public filterArray: Member[] = this.memberList;

  showMemberDetails(member: Member) {
    this.selectedMember = member
    this.isShowDetails = true
  }

  filterMembers() {
    console.log("filter");
    this.filterArray = this.memberList.filter((member) =>
      member.FullName.includes(this.searchInput) || member.model.includes(this.searchInput)
    )
  }

  addNewMember(member: Member) {
    this.memberList.push(member)
    this.isShowAddMember = false
  }
}

