import { Component, OnInit } from '@angular/core';
import { AxiosService } from 'src/services/AxiosService';


@Component({
  selector: 'app-modals',
  templateUrl: './modals.component.html',
  styleUrls: ['./modals.component.css']
})
export class ModalsComponent implements OnInit {

  constructor(private service:AxiosService) { }

  ngOnInit(): void {
    this.service.GetAllProducts();
  }
}

