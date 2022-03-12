import { Component, OnInit } from '@angular/core';
import { Address } from '../../../models/Address'
import { AddressService } from '../../../services/address/address.service'

@Component({
  selector: 'app-address-list',
  templateUrl: './address-list.component.html',
  styleUrls: ['../../../app.component.scss']
})

export class AddressListComponent implements OnInit {
  addresses: Address[];

  constructor(private addressService: AddressService) { }

  ngOnInit() {
    this.getAllAddresses();
  }

  private getAllAddresses() {
    this.addressService.getAll().subscribe(response => {
      this.addresses = response;
    });
  }
}
