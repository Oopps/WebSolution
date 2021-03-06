import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html'
})
export class CustomersComponent {
  public customers: Customers[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Customers[]>(baseUrl + 'customers').subscribe(result => {
      this.customers = result;
    }, error => console.error(error));
  }
}

interface Customers {
  customerName: string;
  customerAddress: string;
  totalOrderedCost: number;
  ordersCount: number;
}
