import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import HomePage from '../views/HomePage.vue'
import GioiThieu from '../views/GioiThieu.vue'
import DatVe from '../views/DatVe.vue'
import TimVe from '../views/TimKiemVe.vue'
import TimChuyen from '../views/TimKiemChuyen.vue'
import TimTuyen from '../views/TimKiemTuyen.vue'
import QlyVeXe from '../views/VeXe/QlyVeXe.vue'
import QlyChuyenXe from '../views/ChuyenXe/QLyChuyenXe.vue'
import QlyTuyenXe from '../views/TuyenXe/QlyTuyenXe.vue'
import QlyKhachHang from '../views/KhachHang/QlyKhachHang.vue'
import FormVeXe from '../views/VeXe/Form.vue'
import FormChuyenXe from '../views/ChuyenXe/Form.vue'
import FormTuyenXe from '../views/TuyenXe/Form.vue'
import FormKhachHang from '../views/KhachHang/Form.vue'
import FormEditChuyenXe from '../views/ChuyenXe/FormEdit.vue'
import FormEditVeXe from '../views/VeXe/FormEdit.vue'
import FormEditTuyenXe from '../views/TuyenXe/FormEdit.vue'
import FormEditKhachHang from '../views/KhachHang/FormEdit.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomePage
  },
  {
    path: '/gioithieu',
    name: 'gioithieu',
    component: GioiThieu
  },
  {
    path: '/datve',
    name: 'datve',
    component: DatVe
  },
  {
    path: '/timkiemve',
    name: 'timkiemve',
    component: TimVe
  },
  {
    path: '/timkiemchuyen',
    name: 'timkiemchuyen',
    component: TimChuyen
  },
  {
    path: '/timkiemtuyen',
    name: 'timkiemtuyen',
    component: TimTuyen
  },
  {
    path: '/qly',
    name: 'qly',
    component: QlyVeXe
  },
  {
    path: '/qlychuyen',
    name: 'qlychuyen',
    component: QlyChuyenXe
  },
  {
    path: '/qlytuyen',
    name: 'qlytuyen',
    component: QlyTuyenXe
  },
  {
    path: '/qlykh',
    name: 'qlykh',
    component: QlyKhachHang
  },
  {
    path: '/formvexe',
    name: 'formvexe',
    component: FormVeXe
  },
  {
    path: '/formchuyenxe',
    name: 'formchuyenxe',
    component: FormChuyenXe
  },
  {
    path: '/formtuyenxe',
    name: 'formtuyenxe',
    component: FormTuyenXe
  },
  {
    path: '/formkhachhang',
    name: 'formkhachhang',
    component: FormKhachHang
  },
  {
    path: '/formeditve/:name',
    name: 'formedit',
    component: FormEditVeXe
  },
  {
    path: '/formeditchuyen/:name',
    name: 'formeditchuyen',
    component: FormEditChuyenXe
  },
  {
    path: '/formedittuyen/:name',
    name: 'formedittuyen',
    component: FormEditTuyenXe
  },
  {
    path: '/formeditkhachhang/:name',
    name: 'formeditkhachhang',
    component: FormEditKhachHang
  },
  {
    path: '/about',
    name: 'about',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue')
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
