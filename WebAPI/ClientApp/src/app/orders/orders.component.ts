import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html'
})
export class OrdersComponent {
  public orders: Orders[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Orders[]>(baseUrl + 'orders').subscribe(result => {
      this.orders = result;
    }, error => console.error(error));
  }
}

interface Orders {
  orderNumber: number;
  customer: Customers;
  totalCost: number;
  status: string;
}

interface Customers {
  customerName: string;
  customerAddress: string;
  totalOrderedCost: number;
  ordersCount: number;
}
